// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591