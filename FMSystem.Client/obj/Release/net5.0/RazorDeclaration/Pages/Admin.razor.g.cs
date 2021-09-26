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
#line 3 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Admin.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Admin.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Admin.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Admin.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Admin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 209 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Pages\Admin.razor"
       

    private User[] users, showingUsers = new List<User>().ToArray();
    private IEnumerable<User> selectedUsers;
    private User detailUser;
    private string searchName, permission;
    private int tablePageIndex;
    private bool modalVisible;

    private AntDesign.Table<User> table;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await RefrashData();
    }

    private async Task RefrashData()
    {
        users = await Http.GetFromJsonAsync<User[]>("Api/User/GetUser");
        await RefrashTable();
    }

    private async Task RefrashTable()
    {
        showingUsers = users;

        //过滤种类
        if (permission == "admin")
        {
            showingUsers = showingUsers.Where(i => i.Permission == Permissions.ADMIN).ToArray();
        }
        else if (permission == "normal")
        {
            showingUsers = showingUsers.Where(i => i.Permission == Permissions.NORMAL).ToArray();
        }

        //过滤名称
        if (searchName != null && searchName != "")
        {
            showingUsers = showingUsers.Where(i => i.UserName.ToLower().Contains(searchName.ToLower())).ToArray();
        }
    }


    private bool dwVisible1, dwVisible2, loading1, loading2;
    private AntDesign.Form<User> form1, form2;
    private User newUser = new() { Permission = Permissions.NORMAL };
    private User editUser = new();
    private bool self = false;


    public class Option
    {
        public string Value { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
    }

    private List<Option> options = new List<Option>()
{
        new Option {Value = "all", Name = "全部"},
        new Option {Value = "admin", Name = "管理员"},
        new Option {Value = "normal", Name = "普通用户"}
    };

    public class realOption
    {
        public Permissions Value { get; set; }
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
    }

    private List<realOption> newOptions = new List<realOption>()
{
        new realOption {Value = Permissions.ADMIN, Name = "管理员"},
        new realOption {Value = Permissions.NORMAL, Name = "普通用户"}
    };



    private async Task NewOnSubmit()
    {
        Response response = await Http.GetFromJsonAsync<Response>("Api/User/IsUserExist?username=" + newUser.UserName);
        if (response.Msg == "Yes")
        {
            messageService.Error("用户名已存在");
        }
        else
        {
            loading1 = true;
            form1.Submit();
        }
    }

    private async Task NewOnFinish(EditContext newContext)
    {
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/AddUser", newContext.Model);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData();   //刷新表格
            newUser = new User() { Permission = Permissions.NORMAL };  //清空表单
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
        if (selectedUsers == null || selectedUsers.Count() == 0)
        {
            messageService.Error("请先选中一行数据");
        }
        else if (selectedUsers.Count() != 1)
        {
            messageService.Error("只能对单项进行编辑");
        }
        else
        {
            editUser = new()
            {
                Id = selectedUsers.First().Id,
                UserName = selectedUsers.First().UserName,
                UserPwd = selectedUsers.First().UserPwd,
                Permission = selectedUsers.First().Permission,
                QQ = selectedUsers.First().QQ,
                Email = selectedUsers.First().Email,
                PhoneNumber = selectedUsers.First().PhoneNumber,
                Address = selectedUsers.First().Address
            };
            dwVisible2 = true;

            //不得修改自己的权限组
            AuthenticationState authState = authenticationStateTask.Result;
            ClaimsPrincipal user = authState.User;
            if (editUser.UserName == user.Identity.Name)
            {
                self = true;
            }
            else
            {
                self = false;
            }
        }
    }

    private async Task EditOnSubmit()
    {
        Response response = await Http.GetFromJsonAsync<Response>("Api/User/IsUserExist?username=" + editUser.UserName);
        if (response.Msg == "Yes" && editUser.UserName.ToLower() != selectedUsers.First().UserName.ToLower())
        {
            messageService.Error("用户名已存在");
        }
        else
        {
            loading2 = true;
            form2.Submit();
        }
    }

    private async Task EditOnFinish(EditContext editContext)
    {
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/EditUser", editContext.Model);
        Response response = await (responseMsg).Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData();   //刷新表格
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

    private bool editLoading, modalVisible1, modalVisible2, modalVisible3;
    private string editPwd;


    private async Task OnResetPwd()
    {
        if (editPwd == "") return;
        modalVisible1 = false;
        editLoading = true;
        int[] ids = selectedUsers.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/ResetUserPwd?password=" + editPwd, ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData();   //刷新表格
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
        int[] ids = selectedUsers.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/ClearUserData", ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData();   //刷新表格
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
        if (selectedUsers.Any(i => i.UserName == user.Identity.Name))
        {
            messageService.Error("不得删除自己");
            return;
        }
        modalVisible3 = false;
        editLoading = true;
        int[] ids = selectedUsers.Select(i => i.Id).ToArray();
        HttpResponseMessage responseMsg = await Http.PostAsJsonAsync("Api/User/DeleteUser", ids);
        Response response = await responseMsg.Content.ReadFromJsonAsync<Response>();
        if (response.Type == 1)
        {
            await RefrashData();   //刷新表格
            editLoading = false;
            messageService.Success("删除成功");
        }
        else
        {
            editLoading = false;
            messageService.Error("删除失败");
        }
    }



    private async Task ShowDetail(int id)
    {
        detailUser = users.FirstOrDefault(i => i.Id == id);
        modalVisible = true;
    }

    private async Task HandleOk()
    {
        editUser = new()
        {
            Id = detailUser.Id,
            UserName = detailUser.UserName,
            UserPwd = detailUser.UserPwd,
            Permission = detailUser.Permission,
            QQ = detailUser.QQ,
            Email = detailUser.Email,
            PhoneNumber = detailUser.PhoneNumber,
            Address = detailUser.Address
        };
        modalVisible = false;
        dwVisible2 = true;

        //不得修改自己的权限组
        AuthenticationState authState = authenticationStateTask.Result;
        ClaimsPrincipal user = authState.User;
        if (editUser.UserName == user.Identity.Name)
        {
            self = true;
        }
        else
        {
            self = false;
        }
    }

    private async Task HandleCancel()
    {
        modalVisible = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService messageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
