#pragma checksum "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73f75249cd2b498c0a0e5517fb821405f0ecdb4"
// <auto-generated/>
#pragma warning disable 1591
namespace FMSystem.Client.Components.Admin
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
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class PluralInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "float: right; margin-bottom: 24px;");
            __builder.OpenComponent<AntDesign.Spin>(2);
            __builder.AddAttribute(3, "Spinning", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                    editLoading

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Button>(5);
                __builder2.AddAttribute(6, "Type", "primary");
                __builder2.AddAttribute(7, "Danger", true);
                __builder2.AddAttribute(8, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                                                 () => { if (Selected != null && Selected.Count() != 0) modalVisible1 = true; }

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "重置密码");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Button>(12);
                __builder2.AddAttribute(13, "Danger", true);
                __builder2.AddAttribute(14, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                                  () => { if (Selected != null && Selected.Count() != 0) modalVisible2 = true; }

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "清空数据");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Button>(18);
                __builder2.AddAttribute(19, "Type", "dashed");
                __builder2.AddAttribute(20, "Danger", true);
                __builder2.AddAttribute(21, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                                                () => { if (Selected != null && Selected.Count() != 0) modalVisible3 = true; }

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "删除");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenComponent<AntDesign.Modal>(25);
            __builder.AddAttribute(26, "Title", "提示");
            __builder.AddAttribute(27, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Double>>(
#nullable restore
#line 14 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
              300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                 modalVisible1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
             OnResetPwd

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(30, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                   () => { modalVisible1 = false; }

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Text>(32);
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "重置选中用户密码为");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __Blazor.FMSystem.Client.Components.Admin.PluralInput.TypeInference.CreateInput_0(__builder2, 36, 37, "例: 123456", 38, 
#nullable restore
#line 19 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                                                                    32

#line default
#line hidden
#nullable disable
                , 39, 
#nullable restore
#line 19 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                        editPwd

#line default
#line hidden
#nullable disable
                , 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => editPwd = __value, editPwd)), 41, () => editPwd);
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenComponent<AntDesign.Modal>(43);
            __builder.AddAttribute(44, "Title", "提示");
            __builder.AddAttribute(45, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Double>>(
#nullable restore
#line 23 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
              300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                 modalVisible2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
             OnClearData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(48, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                   () => { modalVisible2 = false; }

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Text>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "清除选中用户数据");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n\r\n");
            __builder.OpenComponent<AntDesign.Modal>(54);
            __builder.AddAttribute(55, "Title", "提示");
            __builder.AddAttribute(56, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Double>>(
#nullable restore
#line 31 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
              300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                 modalVisible3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "OnOk", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
             OnDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(59, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
                   () => { modalVisible3 = false; }

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Text>(61);
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(63, "删除选中用户");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Admin\PluralInput.razor"
       

    [Parameter]
    public IEnumerable<User> Selected { get; set; }
    [Parameter]
    public EventCallback Refrash { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private bool editLoading, modalVisible1, modalVisible2, modalVisible3;
    private string editPwd;


    private async Task OnResetPwd()
    {
        if (editPwd == "") return;
        modalVisible1 = false;
        editLoading = true;
        int[] ids = Selected.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/ResetUserPwd?password=" + editPwd, ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await Refrash.InvokeAsync();   //刷新表格
            editLoading = false;
            messageService.Success("重置成功");
        }
        else
        {
            editLoading = false;
            messageService.Error("重置失败");
        }
    }

    private async Task OnClearData()
    {
        modalVisible2 = false;
        editLoading = true;
        int[] ids = Selected.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/ClearUserData", ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await Refrash.InvokeAsync();   //刷新表格
            editLoading = false;
            messageService.Success("清除成功");
        }
        else
        {
            editLoading = false;
            messageService.Error("清除失败");
        }
    }

    private async Task OnDelete()
    {
        AuthenticationState authState = await authenticationStateTask;
        ClaimsPrincipal user = authState.User;
        if (Selected.Any(i => i.UserName == user.Identity.Name))
        {
            messageService.Error("不得删除自己");
            return;
        }
        modalVisible3 = false;
        editLoading = true;
        int[] ids = Selected.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/DeleteUser", ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await Refrash.InvokeAsync();   //刷新表格
            editLoading = false;
            messageService.Success("删除成功");
        }
        else
        {
            editLoading = false;
            messageService.Error("删除失败");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService messageService { get; set; }
    }
}
namespace __Blazor.FMSystem.Client.Components.Admin.PluralInput
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Int32 __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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