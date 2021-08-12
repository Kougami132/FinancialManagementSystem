using Blazored.LocalStorage;
using FMSystem.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace FMSystem.Client
{
    public class AuthProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        ILocalStorageService _localstorage;
        public string UserName { get; set; }

        public AuthProvider(HttpClient httpClient, ILocalStorageService localstorage)
        {
            _httpClient = httpClient;
            _localstorage = localstorage;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //这里获得用户登录状态
            string token = await _localstorage.GetItemAsStringAsync("authToken");
            if (string.IsNullOrWhiteSpace(token))
            {
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
            UserDto result = await _httpClient.GetFromJsonAsync<UserDto>($"api/Auth/GetUser");

            if (result?.Name == null)
            {
                MarkUserAsLoggedOut();
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }
            else
            {
                MarkUserAsAuthenticated(result);
                var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(result.Token), "apiauth"));
                return new AuthenticationState(authenticatedUser);
            }
        }

        /// <summary>
        /// 标记授权
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public void MarkUserAsAuthenticated(UserDto userDto)
        {
            //在header上添加token
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", userDto.Token);
            UserName = userDto.Name;

            //把token转为验证状态
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(userDto.Token), "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);

            //此处可以将Token存储在本地存储中，实现页面刷新无需登录
            _localstorage.SetItemAsStringAsync("authToken", userDto.Token);
        }

        /// <summary>
        /// 标记注销
        /// </summary>
        public void MarkUserAsLoggedOut()
        {
            //清空header
            _httpClient.DefaultRequestHeaders.Authorization = null;
            UserName = null;

            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(anonymousUser));
            NotifyAuthenticationStateChanged(authState);

            _localstorage.RemoveItemAsync("authToken");
        }



        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
