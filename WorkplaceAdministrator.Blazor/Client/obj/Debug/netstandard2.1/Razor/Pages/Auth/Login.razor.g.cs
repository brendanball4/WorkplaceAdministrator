#pragma checksum "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85253296593fb0180efdb41e200a74a3233f3a53"
// <auto-generated/>
#pragma warning disable 1591
namespace WorkplaceAdministrator.Blazor.Pages.Auth
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
#line 4 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
using WorkplaceAdministrator.Common.Dtos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/auth/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "class", "login-container");
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
                                             loginInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
                                                                       AttemptLoginAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "login-form");
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.AddMarkupContent(9, "<h1 class=\"text-center\">Login</h1>\r\n            <hr>\r\n            <br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(14);
                __builder2.AddAttribute(15, "CssClass", "email-input");
                __builder2.AddAttribute(16, "Placeholder", "Email");
                __builder2.AddAttribute(17, "value", 
#nullable restore
#line 18 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
                                                                               loginInfo.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(18, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginInfo.Email = __value, loginInfo.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(20);
                __builder2.AddAttribute(21, "Placeholder", "Password");
                __builder2.AddAttribute(22, "Type", "password");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
                                                                           loginInfo.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => loginInfo.Password = __value, loginInfo.Password))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => loginInfo.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(27, "<p class=\"text-center\" style=\"display: none;\" id=\"text\">WARNING! Caps lock is ON.</p>\r\n            \r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(28, "<button class=\"btn-block btn-primary\" type=\"submit\">Log in</button>\r\n            ");
                __builder2.OpenElement(29, "button");
                __builder2.AddAttribute(30, "class", "btn-block btn-primary");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
                                                            GoToRegister

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(32, "Apply for volunteering");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n            ");
                __builder2.AddMarkupContent(34, "<a id=\"forgot-password\">Forgot your password?</a>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Chase\Desktop\FBWebsite-V2\WorkplaceAdministrator\WorkplaceAdministrator.Blazor\Client\Pages\Auth\Login.razor"
       
    LoginDto loginInfo = new LoginDto();

    private async void AttemptLoginAsync()
    {
        var response = await ((WorkplaceAuthStateProvider)_authStateProvider).LoginAsync(loginInfo);

        bool auth = response.User.Identity.IsAuthenticated;

        if (response.User.Identity.IsAuthenticated)
        {
            if (response.User.IsInRole("Admin") || response.User.IsInRole("Staff"))
            {
                _navManager.NavigateTo("/admin/list");
            }
            else
            {
                _navManager.NavigateTo("/members/index");
            }
        }
    }

    private void GoToRegister()
    {
        _navManager.NavigateTo("/auth/register");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider _authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navManager { get; set; }
    }
}
#pragma warning restore 1591