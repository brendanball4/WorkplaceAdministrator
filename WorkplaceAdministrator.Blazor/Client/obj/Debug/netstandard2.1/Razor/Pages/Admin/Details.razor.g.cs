#pragma checksum "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc027c84592f649483cab032e120d5f9ba4c61a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/details/{Id}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
 if (CurrentAccount == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>Loading Details...</p>\r\n");
#nullable restore
#line 6 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, "Details for ");
            __builder.AddContent(5, 
#nullable restore
#line 9 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                     CurrentAccount.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 9 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                                               CurrentAccount.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                     CurrentAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                                                    SaveChangesAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.AddMarkupContent(14, "<label>First Name</label>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                                CurrentAccount.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentAccount.FirstName = __value, CurrentAccount.FirstName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentAccount.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n\r\n        ");
                __builder2.AddMarkupContent(20, "<label>Last Name</label>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(21);
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                                CurrentAccount.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentAccount.LastName = __value, CurrentAccount.LastName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentAccount.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n\r\n        ");
                __builder2.AddMarkupContent(26, "<label>Email</label>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(27);
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
                                CurrentAccount.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CurrentAccount.Email = __value, CurrentAccount.Email))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => CurrentAccount.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 20 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Admin\Details.razor"
       
    [Parameter]
    public string Id { get; set; }
    public AccountAdminReadEditDto CurrentAccount { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Guid id = new Guid(Id);
        CurrentAccount = await _accountRepo.GetUserByIdForAdmin(id);
    }

    public async void SaveChangesAsync()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountRepo _accountRepo { get; set; }
    }
}
#pragma warning restore 1591
