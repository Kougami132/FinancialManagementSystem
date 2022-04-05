#pragma checksum "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528a9629019cdaa6088c9052baf7c8269c59d0ca"
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
#line 13 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<FMSystem.Client.Shared.PageTitle>(0);
            __builder.AddAttribute(1, "Title", "注册 - 个人财务管理系统");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<AntDesign.Card>(3);
            __builder.AddAttribute(4, "Bordered", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                              "注册新用户"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Style", "width:400px; cursor: default;");
            __builder.AddAttribute(7, "Hoverable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.FMSystem.Client.Pages.Register.TypeInference.CreateForm_0(__builder2, 9, 10, 
#nullable restore
#line 13 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                       registerLoading

#line default
#line hidden
#nullable disable
                , 11, 
#nullable restore
#line 14 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                       FormLayout.Vertical

#line default
#line hidden
#nullable disable
                , 12, 
#nullable restore
#line 15 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                      registerUser

#line default
#line hidden
#nullable disable
                , 13, 
#nullable restore
#line 16 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                true

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                        OnRegister

#line default
#line hidden
#nullable disable
                ), 15, "padding: 12px;", 16, (context) => (__builder3) => {
                    __builder3.OpenComponent<AntDesign.FormItem>(17);
                    __builder3.AddAttribute(18, "Label", "用户名");
                    __builder3.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.FMSystem.Client.Pages.Register.TypeInference.CreateInput_1(__builder4, 20, 21, "例: test132", 22, 
#nullable restore
#line 20 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                           16

#line default
#line hidden
#nullable disable
                        , 23, 
#nullable restore
#line 20 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                     context.UserName

#line default
#line hidden
#nullable disable
                        , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.UserName = __value, context.UserName)), 25, () => context.UserName);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.FormItem>(27);
                    __builder3.AddAttribute(28, "Label", "密码");
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.InputPassword>(30);
                        __builder4.AddAttribute(31, "Placeholder", "例: 123456");
                        __builder4.AddAttribute(32, "MaxLength", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 23 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                                 32

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                             context.UserPwd

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.UserPwd = __value, context.UserPwd))));
                        __builder4.AddAttribute(35, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.UserPwd));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "style", "margin-bottom: 24px;");
                    __builder3.AddMarkupContent(39, "<div style=\"padding-bottom: 8px;\"><label style=\"height: 22px; font-size: 14px;\"><span style=\"color: red;\">*</span>&nbsp;再次输入密码</label></div>\r\n                ");
                    __builder3.OpenComponent<AntDesign.InputPassword>(40);
                    __builder3.AddAttribute(41, "Placeholder", "例: 123456");
                    __builder3.AddAttribute(42, "MaxLength", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 29 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                          32

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                             password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => password = __value, password))));
                    __builder3.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => password));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(46, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.FormItem>(47);
                    __builder3.AddAttribute(48, "WrapperColOffset", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 31 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "WrapperColSpan", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 31 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                           24

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Button>(51);
                        __builder4.AddAttribute(52, "Type", "default");
                        __builder4.AddAttribute(53, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                  ()=> { navigationManager.NavigateTo("/login"); }

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(55, "取&nbsp;消");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.Button>(57);
                        __builder4.AddAttribute(58, "Type", "primary");
                        __builder4.AddAttribute(59, "HtmlType", "submit");
                        __builder4.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(61, "注&nbsp;册");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
       

    bool registerLoading = false;
    User registerUser = new() { Permission = Permissions.NORMAL };
    string password = "";

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        AuthenticationState authState = await authenticationStateTask;
        ClaimsPrincipal user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/");
            return;
        }
    }

    public async Task OnRegister()
    {
        if (password != registerUser.UserPwd)
        {
            messageService.Error("两次输入密码不一致");
            password = "";
            return;
        }

        registerLoading = true;
        Response res = await Http.GetFromJsonAsync<Response>($"Api/User/IsUserExist?username=" + registerUser.UserName);
        if (res.Type == 1 && res.Msg == "Yes")
        {
            messageService.Error("用户名已存在");
            registerLoading = false;
            return;
        }

        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Auth/Register", registerUser);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            messageService.Success("注册成功");
            navigationManager.NavigateTo("/login");
        }
        else
        {
            messageService.Error("注册失败");
        }
        registerLoading = false;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService messageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.FMSystem.Client.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateForm_0<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.String __arg1, int __seq2, TModel __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg6)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Loading", __arg0);
        __builder.AddAttribute(__seq1, "Layout", __arg1);
        __builder.AddAttribute(__seq2, "Model", __arg2);
        __builder.AddAttribute(__seq3, "ValidateOnChange", __arg3);
        __builder.AddAttribute(__seq4, "OnFinish", __arg4);
        __builder.AddAttribute(__seq5, "Style", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "MaxLength", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
