#pragma checksum "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Alerts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65590e6ed3b0fe6a43e37ce9d050b7e81c1f7d4"
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
#line 12 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Blazor.Shared;

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
#line 2 "C:\Users\dofus\Downloads\FBWebsite-V2-master(1)\FBWebsite-V2-master\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Alerts.razor"
           [Authorize(Roles = "SuperAdmin, Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/alerts")]
    public partial class Alerts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
