#pragma checksum "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\List.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501f3ac4680eeb0cc1548f0796ed30d1fe75c6ce"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WorkplaceAdministrator.Blazor.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Common.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Blazor.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\List.razor"
using WorkplaceAdministrator.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\List.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\List.razor"
           [Authorize(Roles = "Staff, Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/list")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\List.razor"
       
    public List<AccountAdminListDto> Members { get; set; }

    private SfGrid<AccountAdminListDto> AccountsGrid;

    protected async override Task OnInitializedAsync()
    {
        Members = await _accountRepo.GetAllUsers();
    }

    private async Task OnContextMenuClick(ContextMenuClickEventArgs args)
    {
        if (args.Item.Id == "seeDetails")
        {
            var selectedRows = await AccountsGrid.GetSelectedRecords();
            var id = selectedRows.FirstOrDefault().Id;
            _navManager.NavigateTo($"/admin/details/{id.ToString()}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountRepo _accountRepo { get; set; }
    }
}
#pragma warning restore 1591
