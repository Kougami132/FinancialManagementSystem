#pragma checksum "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e7929ad172f90d113634a6915fc45471e7b12e"
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
#line 5 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/records")]
    public partial class Records : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<FMSystem.Client.Components.Record.FilterAndInput>(0);
            __builder.AddAttribute(1, "RefrashData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                               RefrashData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "RefrashTable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 17 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                RefrashTable

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "categories", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FMSystem.Shared.Category>>(
#nullable restore
#line 9 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                    categories

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "categoriesChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<FMSystem.Shared.Category>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<FMSystem.Shared.Category>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => categories = __value, categories))));
            __builder.AddAttribute(5, "accounts", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FMSystem.Shared.Account>>(
#nullable restore
#line 10 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                  accounts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "accountsChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<FMSystem.Shared.Account>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<FMSystem.Shared.Account>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => accounts = __value, accounts))));
            __builder.AddAttribute(7, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                              type

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "TypeChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => type = __value, type))));
            __builder.AddAttribute(9, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                  category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "CategoryChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category = __value, category))));
            __builder.AddAttribute(11, "Account", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                 account

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "AccountChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => account = __value, account))));
            __builder.AddAttribute(13, "DateFilter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?[]>(
#nullable restore
#line 14 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                    dateFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "DateFilterChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?[]>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dateFilter = __value, dateFilter))));
            __builder.AddAttribute(15, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FMSystem.Shared.Record>>(
#nullable restore
#line 15 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                                  selectedRecords

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "SelectedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<FMSystem.Shared.Record>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<FMSystem.Shared.Record>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedRecords = __value, selectedRecords))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenComponent<FMSystem.Client.Components.Record.TableInput>(18);
            __builder.AddAttribute(19, "Obj", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.Table<FMSystem.Shared.Record>>(
#nullable restore
#line 20 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                   table

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<FMSystem.Shared.Record[]>(
#nullable restore
#line 21 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                    showingRecords

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Selected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<FMSystem.Shared.Record>>(
#nullable restore
#line 22 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
                                                              selectedRecords

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "SelectedChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<FMSystem.Shared.Record>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<FMSystem.Shared.Record>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedRecords = __value, selectedRecords))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Records.razor"
       

    private Record[] records, showingRecords = new List<Record>().ToArray();
    private IEnumerable<Category> categories;
    private IEnumerable<Account> accounts;
    private IEnumerable<Record> selectedRecords;
    private string type = "all";
    private int category = -1, account = -1;
    private DateTime?[] dateFilter;

    private AntDesign.Table<Record> table;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        categories = await Http.GetFromJsonAsync<Category[]>("Api/Category/GetCategory");
        accounts = await Http.GetFromJsonAsync<Account[]>("Api/Account/GetAccount");
        await RefrashData();
    }

    private async Task RefrashData()
    {
        records = await Http.GetFromJsonAsync<Record[]>("Api/Record/GetRecord");
        await RefrashTable();
    }

    private async Task RefrashTable()
    {
        showingRecords = records;

        //过滤收/支
        if (type == "input")
        {
            showingRecords = showingRecords.Where(i => i.Type == InputOrOutput.INPUT).ToArray();
        }
        else if (type == "output")
        {
            showingRecords = showingRecords.Where(i => i.Type == InputOrOutput.OUTPUT).ToArray();
        }

        //过滤分类

        if (category == -1)
        {
            //全部
        }
        else if (category == -2)
        {
            showingRecords = showingRecords.Where(i => !categories.Any(j => j.Id == i.Category)).ToArray();
        }
        else
        {
            showingRecords = showingRecords.Where(i => i.Category == category).ToArray();
        }

        //过滤账户
        if (account == -1)
        {
            //全部
        }
        else if (account == -2)
        {
            showingRecords = showingRecords.Where(i => !accounts.Any(j => j.Id == i.Account)).ToArray();
        }
        else
        {
            showingRecords = showingRecords.Where(i => i.Account == account).ToArray();
        }

        //过滤日期
        if (dateFilter[0] != null)
        {
            DateTime date = Convert.ToDateTime(dateFilter[0]);
            date = Convert.ToDateTime(date.ToShortDateString());
            showingRecords = showingRecords.Where(i => DateTime.Compare(i.CreateTime, date) >= 0).ToArray();
        }
        if (dateFilter[1] != null)
        {
            DateTime date = Convert.ToDateTime(dateFilter[1]);
            date = Convert.ToDateTime(date.ToShortDateString());
            showingRecords = showingRecords.Where(i => DateTime.Compare(i.CreateTime, date) <= 0).ToArray();
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
