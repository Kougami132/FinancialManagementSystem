// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 4 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\MainLayout.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 247 "E:\Project C#\FinancialManagementSystem\FMSystem.Client\Shared\MainLayout.razor"
      

    private string slideClass = "slide-up";
    private bool collapsed, open;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        AuthenticationState authState = await authenticationStateTask;
        ClaimsPrincipal user = authState.User;
        if (!user.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
