#pragma checksum "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Scheduling.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d6e59a138f7a79d0f4e258e614b5e34b47dace"
// <auto-generated/>
#pragma warning disable 1591
namespace WorkplaceAdministrator.Blazor.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Common.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using WorkplaceAdministrator.Blazor.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Scheduling.razor"
using Syncfusion.Blazor.Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Scheduling.razor"
using WorkplaceAdministrator.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Scheduling.razor"
           [Authorize(Roles = "Admin, Staff")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/schedule")]
    public partial class Scheduling : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Schedule</h1>\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Schedule.SfSchedule<ShiftReadEditDto>>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __Blazor.WorkplaceAdministrator.Blazor.Pages.Admin.Scheduling.TypeInference.CreateScheduleEventSettings_0(__builder2, 4, 5, 
#nullable restore
#line 12 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Scheduling.razor"
                                       Shifts

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Scheduling.razor"
       
    public List<ShiftReadEditDto> Shifts { get; set; }
    public List<AccountAdminListDto> Accounts { get; set; }
    public List<Position> Positions { get; set; }

    protected async override void OnInitialized()
    {
        Shifts = await _shiftRepo.GetAllShifts();
        Accounts = await _accountRepo.GetAllUsers();
        Positions = await _positionRepo.GetAllPositions();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPositionRepo _positionRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountRepo _accountRepo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IShiftRepo _shiftRepo { get; set; }
    }
}
namespace __Blazor.WorkplaceAdministrator.Blazor.Pages.Admin.Scheduling
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateScheduleEventSettings_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Schedule.ScheduleEventSettings<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
