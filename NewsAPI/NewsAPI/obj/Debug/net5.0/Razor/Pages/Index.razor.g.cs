#pragma checksum "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0cbde3dc34fe5680de4d7218fa7e683ac274ae4"
// <auto-generated/>
#pragma warning disable 1591
namespace NewsAPI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using NewsAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\_Imports.razor"
using NewsAPI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
 if (found)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, 
#nullable restore
#line 6 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
         searchFor

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " Latest News");
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
}
else if (topNews)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<h2>Hot Latest News</h2>");
#nullable restore
#line 11 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h2>Latest News</h2>");
#nullable restore
#line 15 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
 if (news == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Getting Latest News...</em></p>");
#nullable restore
#line 20 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mb-5 d-flex justify-content-between");
            __builder.OpenElement(8, "div");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "btn btn-outline-dark");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                           Main

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "All News");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-outline-dark");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                           Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Hot News");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "id", "searchFor");
            __builder.AddAttribute(22, "class", "p-1");
            __builder.AddAttribute(23, "placeholder", "Search for key words. . .");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                     searchFor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchFor = __value, searchFor));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-success");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                      Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "container");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-sm-12");
#nullable restore
#line 36 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                 foreach (var topic in news.data)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "h5");
            __builder.AddAttribute(39, "class", "font-weight-bold");
            __builder.AddContent(40, 
#nullable restore
#line 38 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                  topic.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "https://" + (
#nullable restore
#line 40 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                          topic.source

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "target", "_blank");
            __builder.AddContent(46, "Source: ");
            __builder.AddContent(47, 
#nullable restore
#line 40 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                                                 topic.source

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "small");
            __builder.AddContent(50, 
#nullable restore
#line 41 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                topic.published_at

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "class", "mb-5");
            __builder.AddContent(54, 
#nullable restore
#line 43 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                     topic.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    <hr>");
#nullable restore
#line 45 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "mb-5 d-block mx-auto text-center");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-outline-dark");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                               Previous

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Previous");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-outline-dark");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
                                                               Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
       
    private Root news;
    private string mainUrl = "https://api.thenewsapi.com/v1/news/";
    private string apiKey = "?api_token=kjrZiWCktIwmyvqCgqpox87RCmhIT8k0qgwyx1pW";
    private string errorMessage;
    private string searchFor;
    private int pageNews = 1;
    private bool topNews;
    private bool found;


    private async Task GetNewsAsync()
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "all" + apiKey + "&language=en&page=" + pageNews);
            found = false;
            topNews = false;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    private async Task GetTopNewsAsync()
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "top" + apiKey + "&language=en&page=" + pageNews);
            found = false;
            topNews = true;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            topNews = false;
            errorMessage = e.Message;
        }
    }


    private async Task GetSearchNewsAsync()
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "all" + apiKey + "&search=" + searchFor + "&page=" + pageNews);
            found = true;
            topNews = false;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            found = false;
            errorMessage = e.Message;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await GetNewsAsync();
    }

    public async void Main()
    {
        await GetNewsAsync();
        StateHasChanged();
    }

    public async void Top()
    {
        await GetTopNewsAsync();
        StateHasChanged();
    }

    public async void Search()
    {
        await GetSearchNewsAsync();
        StateHasChanged();
    }

    public void Previous()
    {
        if (found)
        {
            if (pageNews >= 2)
            {
                pageNews--;
            }
            else
            {
                pageNews = 1;
            }
            Search();
            StateHasChanged();
        }
        else if (topNews)
        {
            if (pageNews >= 2)
            {
                pageNews--;
            }
            else
            {
                pageNews = 1;
            }
            Top();
            StateHasChanged();
        }
        else
        {
            if (pageNews >= 2)
            {
                pageNews--;
            }
            else
            {
                pageNews = 1;
            }
            Main();
            StateHasChanged();
        }
    }

    public void Next()
    {
        if (found)
        {
            pageNews++;
            Search();
            StateHasChanged();
        }
        else if (topNews)
        {
            pageNews++;
            Top();
            StateHasChanged();
        }
        else
        {
            pageNews++;
            Main();
            StateHasChanged();
        }
    }

    public class Meta
    {
        public int found { get; set; }
        public int returned { get; set; }
        public int limit { get; set; }
        public int page { get; set; }
    }

    public class Datum
    {
        public string uuid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string snippet { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string language { get; set; }
        public DateTime published_at { get; set; }
        public string source { get; set; }
        public List<string> categories { get; set; }
        public object relevance_score { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
