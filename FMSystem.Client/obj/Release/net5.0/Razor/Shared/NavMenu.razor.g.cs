#pragma checksum "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58161fc18cb01fa0c392f83c6faea37318b05503"
// <auto-generated/>
#pragma warning disable 1591
namespace FMSystem.Client.Shared
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
#line 13 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Menu>(0);
            __builder.AddAttribute(1, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 1 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
            MenuMode.Inline

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "DefaultSelectedKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 2 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
                            new[] {"1"}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "DefaultOpenKeys", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.String>>(
#nullable restore
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
                        new[] {"sub1"}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.MenuItem>(5);
                __builder2.AddAttribute(6, "Key", "1");
                __builder2.AddAttribute(7, "RouterLink", "/");
                __builder2.AddAttribute(8, "RouterMatch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(10);
                    __builder3.AddAttribute(11, "Type", "home");
                    __builder3.AddAttribute(12, "Theme", "outline");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.AddMarkupContent(14, "<span>首页</span>");
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 8 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
      
        RenderFragment sub1Title =
        

#line default
#line hidden
#nullable disable
                (__builder3) => {
                    __builder3.OpenElement(15, "span");
                    __builder3.OpenComponent<AntDesign.Icon>(16);
                    __builder3.AddAttribute(17, "Type", "table");
                    __builder3.AddAttribute(18, "Theme", "outline");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n            ");
                    __builder3.AddMarkupContent(20, "<span>数据管理</span>");
                    __builder3.CloseElement();
                }
#nullable restore
#line 13 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
               ;
    

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<AntDesign.SubMenu>(21);
                __builder2.AddAttribute(22, "Key", "sub1");
                __builder2.AddAttribute(23, "TitleTemplate", new Microsoft.AspNetCore.Components.RenderFragment(
#nullable restore
#line 15 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\NavMenu.razor"
                                       sub1Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.MenuItemGroup>(25);
                    __builder3.AddAttribute(26, "Key", "group1");
                    __builder3.AddAttribute(27, "Title", "记录管理");
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.MenuDivider>(29);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(31);
                        __builder4.AddAttribute(32, "Key", "2");
                        __builder4.AddAttribute(33, "RouterLink", "/records");
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(35, "账单管理");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.MenuItemGroup>(37);
                    __builder3.AddAttribute(38, "Key", "group2");
                    __builder3.AddAttribute(39, "Title", "选项管理");
                    __builder3.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.MenuDivider>(41);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(42, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(43);
                        __builder4.AddAttribute(44, "Key", "3");
                        __builder4.AddAttribute(45, "RouterLink", "/categories");
                        __builder4.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(47, "分类管理");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.MenuItem>(49);
                        __builder4.AddAttribute(50, "Key", "4");
                        __builder4.AddAttribute(51, "RouterLink", "/accounts");
                        __builder4.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(53, "账户管理");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenComponent<AntDesign.MenuItem>(55);
                __builder2.AddAttribute(56, "Key", "5");
                __builder2.AddAttribute(57, "RouterLink", "/settings");
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(59);
                    __builder3.AddAttribute(60, "Type", "user");
                    __builder3.AddAttribute(61, "Theme", "outline");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n        ");
                    __builder3.AddMarkupContent(63, "<span>个人中心</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(65);
                __builder2.AddAttribute(66, "Policy", "Admin");
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<AntDesign.MenuItem>(68);
                    __builder3.AddAttribute(69, "Key", "6");
                    __builder3.AddAttribute(70, "RouterLink", "/admin");
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Icon>(72);
                        __builder4.AddAttribute(73, "Type", "team");
                        __builder4.AddAttribute(74, "Theme", "outline");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(75, "\r\n            ");
                        __builder4.AddMarkupContent(76, "<span>用户管理</span>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
