#pragma checksum "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0be8f82de8e4539505ef6a92413768bf50763ed"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-12 ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "list-group");
#nullable restore
#line 5 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
             if (products == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, @"<div class=""d-flex justify-content-center align-items-center""><div><div class=""spinner-grow"" style=""width: 2rem; height: 2rem; margin: 2rem;"" role=""status""><span class=""visually-hidden"">Loading...</span></div>
                    <div class=""spinner-grow"" style=""width: 2rem; height: 2rem; margin: 2rem;"" role=""status""><span class=""visually-hidden"">Loading...</span></div>
                    <div class=""spinner-grow"" style=""width: 2rem; height: 2rem; margin: 2rem;"" role=""status""><span class=""visually-hidden"">Loading...</span></div></div></div>
             ");
            __builder.AddMarkupContent(7, "<h4 class=\"text-center text-italic\">Loading...</h4>");
#nullable restore
#line 21 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
           
            }
            else
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
              foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container d-flex");
            __builder.OpenComponent<WebApp.Shared.ProductItem>(10);
            __builder.AddAttribute(11, "Item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApp.Models.Product>(
#nullable restore
#line 27 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
                                         product

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\herman\Dropbox\STUDIER\FRONTEND\BACKEND\UPPGIFT\eCommerce\WebApp\Shared\ProductList.razor"
       
    private Product[] products;


    private async Task GetProductsAsync()
    {
        products = await Http.GetFromJsonAsync<Product[]>("https://localhost:44345/api/products");
        Console.WriteLine(products);

    }

    protected override void OnInitialized()
    {
        var timer = new Timer(new TimerCallback(_ => InvokeAsync(() => StateHasChanged())), null, 1000, 1000);
    }


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await GetProductsAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
