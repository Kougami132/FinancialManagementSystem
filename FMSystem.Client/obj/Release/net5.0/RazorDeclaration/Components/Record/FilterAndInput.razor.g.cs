// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FMSystem.Client.Components.Record
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
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Record\FilterAndInput.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class FilterAndInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 150 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Components\Record\FilterAndInput.razor"
       
    [Parameter]
    public IEnumerable<Category> categories { get; set; }
    [Parameter]
    public EventCallback<IEnumerable<Category>> categoriesChanged { get; set; }
    [Parameter]
    public IEnumerable<Account> accounts { get; set; }
    [Parameter]
    public EventCallback<IEnumerable<Account>> accountsChanged { get; set; }
    [Parameter]
    public string Type { get; set; }
    [Parameter]
    public EventCallback<string> TypeChanged { get; set; }
    [Parameter]
    public int Category { get; set; }
    [Parameter]
    public EventCallback<int> CategoryChanged { get; set; }
    [Parameter]
    public int Account { get; set; }
    [Parameter]
    public EventCallback<int> AccountChanged { get; set; }
    [Parameter]
    public IEnumerable<Record> Selected { get; set; }
    [Parameter]
    public EventCallback<IEnumerable<Record>> SelectedChanged { get; set; }
    [Parameter]
    public EventCallback RefrashData { get; set; }
    [Parameter]
    public EventCallback RefrashTable { get; set; }
    [Parameter]
    public DateTime?[] DateFilter { get; set; }
    [Parameter]
    public EventCallback<DateTime?[]> DateFilterChanged { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private bool dwVisible1, dwVisible2, loading1, loading2, deleteLoading, modalVisible;
    private AntDesign.Form<Record> form1, form2;
    private Record newRecord = new();
    private Record editRecord = new();
    private int owner { get; set; }
    private Select<int, Option<int>> fixSelect1, fixSelect2;

    public class Option<T>
    {
        public T Value { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
    }

    private List<Option<int>> categoryOptions = new List<Option<int>>();
    private List<Option<int>> accountOptions = new();

    private List<Option<int>> newCategoryOptions = new List<Option<int>>();
    private List<Option<int>> newAccountOptions = new List<Option<int>>();

    protected async override Task OnInitializedAsync()
    {
        AuthenticationState authState = await authenticationStateTask;
        ClaimsPrincipal user = authState.User;
        owner = (await Http.GetFromJsonAsync<User>("Api/User/GetSelf")).Id;
        categories = await Http.GetFromJsonAsync<Category[]>("Api/Category/GetCategory");
        accounts = await Http.GetFromJsonAsync<Account[]>("Api/Account/GetAccount");

        await RefrashSelect(Type);
        RefrashNewSelect();

        accountOptions.Add(new Option<int> { Value = -1, Name = "全部" });
        newAccountOptions.Add(new Option<int> { Value = -2, Name = "" });
        for (int i = 0; i < accounts.Count(); i++)
        {
            accountOptions.Add(new Option<int> { Value = i, Name = accounts.ElementAt(i).Name });
            newAccountOptions.Add(new Option<int> { Value = accounts.ElementAt(i).Id, Name = accounts.ElementAt(i).Name });
        }
        accountOptions.Add(new Option<int> { Value = -2, Name = "未分类" });
        fixSelect2.Value = -1;
    }

    private async Task RefrashSelect(string type)
    {
        categoryOptions = new()
        {
            new Option<int> { Value = -1, Name = "全部" }
        };
        for (int i = 0; i < categories.Count(); i++)
        {
            if (type == "all" || type == "input" && categories.ElementAt(i).Type == InputOrOutput.INPUT || type == "output" && categories.ElementAt(i).Type == InputOrOutput.OUTPUT)
            {
                categoryOptions.Add(new Option<int> { Value = i, Name = categories.ElementAt(i).Name });
            }
        }
        categoryOptions.Add(new Option<int> { Value = -2, Name = "未分类" });
        fixSelect1.Value = -1;
        await CategoryChanged.InvokeAsync(-1);
    }

    private void RefrashNewSelect()
    {
        newCategoryOptions = new()
        {
            new Option<int> { Value = -2, Name = "" }
        };
        if (dwVisible1)
        {
            for (int i = 0; i < categories.Count(); i++)
            {
                if (newRecord.Type == categories.ElementAt(i).Type)
                {
                    newCategoryOptions.Add(new Option<int> { Value = categories.ElementAt(i).Id, Name = categories.ElementAt(i).Name });
                }
            }
            newRecord.Category = -2;
        }
        else if (dwVisible2)
        {
            for (int i = 0; i < categories.Count(); i++)
            {
                if (editRecord.Type == categories.ElementAt(i).Type)
                {
                    newCategoryOptions.Add(new Option<int> { Value = categories.ElementAt(i).Id, Name = categories.ElementAt(i).Name });
                }
            }
        }
    }

    private async Task NewOnSubmit()
    {
        loading1 = true;
        newRecord.User = owner;
        newRecord.CreateTime = Convert.ToDateTime(newRecord.CreateTime.ToShortDateString());
        if (newRecord.Category == null) newRecord.Category = -2;
        form1.Submit();
    }

    private async Task NewOnFinish(EditContext newContext)
    {
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Record/AddRecord", newContext.Model);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData.InvokeAsync();   //刷新表格
            newRecord = new();  //清空表单
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
            editRecord = new()
            {
                Id = Selected.First().Id,
                Type = Selected.First().Type,
                Category = Selected.First().Category,
                Value = Selected.First().Value,
                Account = Selected.First().Account,
                CreateTime = Selected.First().CreateTime,
                Description = Selected.First().Description
            };
            dwVisible2 = true;
            RefrashNewSelect();
        }
    }

    private async Task EditOnSubmit()
    {
        loading2 = true;
        editRecord.User = owner;
        editRecord.CreateTime = Convert.ToDateTime(editRecord.CreateTime.ToShortDateString());
        if (editRecord.Category == null) editRecord.Category = -2;
        form2.Submit();
    }

    private async Task EditOnFinish(EditContext editContext)
    {
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Record/EditRecord", editContext.Model);
        Response response = await (responseMsg).Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData.InvokeAsync();   //刷新表格
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
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/Record/DeleteRecord", ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData.InvokeAsync();   //刷新表格
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
