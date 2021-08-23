// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FMSystem.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using FMSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using FMSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using FMSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
      

    private bool loading1, loading2;
    private User self = new();
    private User editUser = new();
    private User editPwd = new();
    private string oldPwd, newPwd;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        AuthenticationState authState = await authenticationStateTask;
        ClaimsPrincipal user = authState.User;
        self = await Http.GetFromJsonAsync<User>("Api/User/GetSelf");
        editUser = new()
        {
            Id = self.Id,
            Permission = self.Permission,
            UserName = self.UserName,
            UserPwd = self.UserPwd,
            QQ = self.QQ,
            Email = self.Email
        };
        editPwd = new()
        {
            Id = self.Id,
            Permission = self.Permission,
            UserName = self.UserName,
            UserPwd = "",
            QQ = self.QQ,
            Email = self.Email
        };
    }

    private async Task OnEditInfo()
    {
        loading1 = true;
        Response res = await Http.GetFromJsonAsync<Response>("Api/User/IsUserExist?username=" + editUser.UserName);
        if (res.Msg == "Yes" && editUser.UserName.ToLower() != editUser.UserName.ToLower())
        {
            messageService.Error("用户名已存在");
            return;
        }

        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/EditUser", editUser);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            self = editUser;
            loading1 = false;
            messageService.Success("提交成功,如已修改用户名请重新登录");
        }
        else
        {
            loading1 = false;
            messageService.Error("提交失败");
        }
    }

    private async Task OnResetPwd()
    {
        if (oldPwd != self.UserPwd)
        {
            messageService.Error("旧密码错误");
            oldPwd = "";
            return;
        }
        else if (newPwd != editPwd.UserPwd)
        {
            messageService.Error("两次密码输入不一致");
            newPwd = "";
            return;
        }

        loading2 = true;
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/EditUser", editPwd);
        Response response = await (responseMsg).Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            self = editPwd;
            loading2 = false;
            messageService.Success("修改成功");
            oldPwd = "";
            newPwd = "";
            editPwd.UserPwd = "";
        }
        else
        {
            loading2 = false;
            messageService.Error("修改失败");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService messageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
