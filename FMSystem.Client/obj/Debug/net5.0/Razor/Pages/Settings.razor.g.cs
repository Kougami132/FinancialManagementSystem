#pragma checksum "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ca399c421c690f17a3e9754fd1f393433d906b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<AntDesign.Collapse>(0);
            __builder.AddAttribute(1, "DefaultActiveKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String[]>(
#nullable restore
#line 7 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                              new[]{"1"}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Accordion", true);
            __builder.AddAttribute(3, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                                               false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Style", "width: auto; height: auto;");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Panel>(6);
                __builder2.AddAttribute(7, "Header", "个人信息");
                __builder2.AddAttribute(8, "Key", "1");
                __builder2.AddAttribute(9, "ShowArrow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Row>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(13);
                        __builder4.AddAttribute(14, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 10 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "Style", "text-align: right;");
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "<h1>用户名:</h1>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(18, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.Col>(19);
                        __builder4.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(21, "h1");
                            __builder5.AddContent(22, 
#nullable restore
#line 14 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                     self.UserName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Row>(24);
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(26);
                        __builder4.AddAttribute(27, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 18 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "Style", "text-align: right;");
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(30, "<h1>权限:</h1>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.Col>(32);
                        __builder4.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 22 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                  string p = self.Permission == Permissions.ADMIN ? "管理员" : self.Permission == Permissions.NORMAL ? "普通用户" : "其他";

#line default
#line hidden
#nullable disable
                            __builder5.OpenElement(34, "h1");
                            __builder5.AddContent(35, 
#nullable restore
#line 23 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                     p

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Row>(37);
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(39);
                        __builder4.AddAttribute(40, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 27 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(41, "Style", "text-align: right;");
                        __builder4.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(43, "<h1>QQ:</h1>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(44, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.Col>(45);
                        __builder4.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(47, "h1");
                            __builder5.AddContent(48, 
#nullable restore
#line 31 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                     self.QQ

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Row>(50);
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Col>(52);
                        __builder4.AddAttribute(53, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 35 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(54, "Style", "text-align: right;");
                        __builder4.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(56, "<h1>邮箱:</h1>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(57, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.Col>(58);
                        __builder4.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(60, "h1");
                            __builder5.AddContent(61, 
#nullable restore
#line 39 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                     self.Email

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Panel>(63);
                __builder2.AddAttribute(64, "Header", "修改信息");
                __builder2.AddAttribute(65, "Key", "2");
                __builder2.AddAttribute(66, "ShowArrow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Panel>(68);
                __builder2.AddAttribute(69, "Header", "修改密码");
                __builder2.AddAttribute(70, "Key", "3");
                __builder2.AddAttribute(71, "ShowArrow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
                                            false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n\r\n");
            __builder.AddMarkupContent(73, "<style>\r\n    h1 {\r\n        font-size: 24px;\r\n        margin: 16px;\r\n    }\r\n    Row {\r\n        background-color: white;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Settings.razor"
      

    private bool editing;
    private User self = new();

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        AuthenticationState authState = await authenticationStateTask;
        ClaimsPrincipal user = authState.User;
        self = await Http.GetFromJsonAsync<User>("Api/User/GetSelf");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
