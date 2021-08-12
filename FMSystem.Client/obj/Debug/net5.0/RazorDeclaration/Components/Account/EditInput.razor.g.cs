// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FMSystem.Client.Components.Account
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
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Account\EditInput.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class EditInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Account\EditInput.razor"
       

    [Parameter]
    public string Owner { get; set; }
    [Parameter]
    public EventCallback<string> OwnerChanged { get; set; }
    [Parameter]
    public string SearchValue { get; set; }
    [Parameter]
    public EventCallback<string> SearchValueChanged { get; set; }
    [Parameter]
    public string Type { get; set; }
    [Parameter]
    public EventCallback<string> TypeChanged { get; set; }
    [Parameter]
    public IEnumerable<Account> Selected { get; set; }
    [Parameter]
    public EventCallback<IEnumerable<Account>> SelectedChanged { get; set; }
    [Parameter]
    public EventCallback Refrash { get; set; }

    private bool dwVisible1, dwVisible2, loading1, loading2, deleteLoading, modalVisible;
    private AntDesign.Form<Account> form1, form2;
    private Account newAccount = new() { Type = PaymentType.OTHER };
    private Account editAccount = new();


    public class Option
    {
        public string Value { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
    }

    private List<Option> options = new List<Option>()
{
        new Option {Value = "all", Name = "全部"},
        new Option {Value = "bank", Name = "银行"},
        new Option {Value = "cash", Name = "现金"},
        new Option {Value = "online", Name = "线上"},
        new Option {Value = "pther", Name = "其它"}
    };

    public class realOption
    {
        public PaymentType Value { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
    }

    private List<realOption> newOptions = new List<realOption>()
{
        new realOption {Value = PaymentType.BANK, Name = "银行"},
        new realOption {Value = PaymentType.CASH, Name = "现金"},
        new realOption {Value = PaymentType.ONLINE, Name = "线上"},
        new realOption {Value = PaymentType.OTHER, Name = "其它"}
    };

    private async Task NewOnSubmit()
    {
        Response response = await Http.GetFromJsonAsync<Response>("Api/Account/IsAccountExist?name=" + newAccount.Name);
        if (response.Msg == "Yes")
        {
            messageService.Error("账户已存在");
        }
        else
        {
            loading1 = true;
            newAccount.User = Owner;
            form1.Submit();
        }
    }

    private async Task NewOnFinish(EditContext newContext)
    {
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Account/AddAccount", newContext.Model);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await Refrash.InvokeAsync();   //刷新表格
            newAccount = new() { Type = PaymentType.OTHER };  //清空表单
            loading1 = false;
            dwVisible1 = false;
            messageService.Success("提交成功");
        }
        else
        {
            loading1 = false;
            messageService.Error("提交失败");
        }
    }

    private async Task NewOnFinishFailed(EditContext editContext)
    {
        loading1 = false;
        messageService.Error("提交失败");
    }

    private void OnEdit()
    {
        if (Selected == null || Selected.Count() == 0)
        {
            messageService.Error("请先选中一行数据");
        }
        else if (Selected.Count() != 1)
        {
            messageService.Error("只能对单项进行编辑");
        }
        else
        {
            editAccount = new()
            {
                Id = Selected.First().Id,
                Name = Selected.First().Name,
                Type = Selected.First().Type,
                Description = Selected.First().Description
            };
            dwVisible2 = true;
        }
    }

    private async Task EditOnSubmit()
    {
        Response response = await Http.GetFromJsonAsync<Response>("Api/Account/IsAccountExist?name=" + editAccount.Name);
        if (response.Msg == "Yes" && editAccount.Name != Selected.First().Name)
        {
            messageService.Error("用户名已存在");
        }
        else
        {
            loading2 = true;
            editAccount.User = Owner;
            form2.Submit();
        }
    }

    private async Task EditOnFinish(EditContext editContext)
    {
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Account/EditAccount", editContext.Model);
        Response response = await (responseMsg).Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await Refrash.InvokeAsync();   //刷新表格
            loading2 = false;
            dwVisible2 = false;
            messageService.Success("提交成功");
        }
        else
        {
            loading2 = false;
            messageService.Error("提交失败");
        }

    }

    private async Task EditOnFinishFailed(EditContext editContext)
    {
        loading2 = false;
        messageService.Error("提交失败");
    }

    private async Task OnDelete()
    {
        modalVisible = false;
        deleteLoading = true;
        int[] ids = Selected.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Account/DeleteAccount", ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await Refrash.InvokeAsync();   //刷新表格
            deleteLoading = false;
            messageService.Success("删除成功");
        }
        else
        {
            deleteLoading = false;
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
