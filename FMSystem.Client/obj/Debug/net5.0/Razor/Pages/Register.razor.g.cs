#pragma checksum "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b74f4d1b4c68bdd0d3a8a5fdbf03537865b49af3"
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
            __builder.OpenComponent<AntDesign.Card>(0);
            __builder.AddAttribute(1, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                              "注册新用户"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Style", "width:400px; cursor: default;");
            __builder.AddAttribute(4, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.FMSystem.Client.Pages.Register.TypeInference.CreateForm_0(__builder2, 6, 7, 
#nullable restore
#line 11 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                       registerLoading

#line default
#line hidden
#nullable disable
                , 8, 
#nullable restore
#line 12 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                       FormLayout.Vertical

#line default
#line hidden
#nullable disable
                , 9, 
#nullable restore
#line 13 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                      registerUser

#line default
#line hidden
#nullable disable
                , 10, 
#nullable restore
#line 14 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                true

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                        OnRegister

#line default
#line hidden
#nullable disable
                ), 12, "padding: 12px;", 13, (context) => (__builder3) => {
                    __builder3.OpenComponent<AntDesign.FormItem>(14);
                    __builder3.AddAttribute(15, "Label", "用户名");
                    __builder3.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __Blazor.FMSystem.Client.Pages.Register.TypeInference.CreateInput_1(__builder4, 17, 18, "例: test132", 19, 
#nullable restore
#line 18 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                           16

#line default
#line hidden
#nullable disable
                        , 20, 
#nullable restore
#line 18 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                     context.UserName

#line default
#line hidden
#nullable disable
                        , 21, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.UserName = __value, context.UserName)), 22, () => context.UserName);
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.FormItem>(24);
                    __builder3.AddAttribute(25, "Label", "密码");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.InputPassword>(27);
                        __builder4.AddAttribute(28, "Placeholder", "例: 123456");
                        __builder4.AddAttribute(29, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                                 32

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                             context.UserPwd

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.UserPwd = __value, context.UserPwd))));
                        __builder4.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.UserPwd));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "style", "margin: 10px 0;");
                    __builder3.AddMarkupContent(36, "<label><span style=\"color: red;\">*</span>&nbsp;再次输入密码</label>\r\n                ");
                    __builder3.OpenComponent<AntDesign.InputPassword>(37);
                    __builder3.AddAttribute(38, "Placeholder", "例: 123456");
                    __builder3.AddAttribute(39, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                                                          32

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                             password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => password = __value, password))));
                    __builder3.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => password));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenComponent<AntDesign.FormItem>(44);
                    __builder3.AddAttribute(45, "WrapperColOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 27 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                        6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "WrapperColSpan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 27 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                           24

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Button>(48);
                        __builder4.AddAttribute(49, "Type", "default");
                        __builder4.AddAttribute(50, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
                                                  ()=> { navigationManager.NavigateTo("/login"); }

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(52, "取&nbsp;消");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(53, "\r\n                ");
                        __builder4.OpenComponent<AntDesign.Button>(54);
                        __builder4.AddAttribute(55, "Type", "primary");
                        __builder4.AddAttribute(56, "HtmlType", "submit");
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(58, "注&nbsp;册");
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
#line 35 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Register.razor"
       

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
