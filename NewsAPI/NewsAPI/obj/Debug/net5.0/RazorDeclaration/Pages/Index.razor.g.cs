// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 3 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
using ValidateSearch;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\lafaman\Desktop\lafamans\ITT\Year4\EAD\CA3\BlazorCA3NewsAPI\NewsAPI\NewsAPI\Pages\Index.razor"
       
    private Root news;
    private string mainUrl = "https://api.thenewsapi.com/v1/news/";
    private string apiKey = "?api_token=kjrZiWCktIwmyvqCgqpox87RCmhIT8k0qgwyx1pW";
    private string errorMessage;
    private int pageNews = 1;
    private bool topNews;
    private bool found;
    //do comments in code
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
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "all" + apiKey + "&search=" + currentSearch.SearchInput + "&language=en&page=" + pageNews);
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
            currentSearch = searchFor;
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
            currentSearch = searchFor;
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

    private ValidSearch currentSearch = new ValidSearch();
    private ValidSearch searchFor = null;

    private void SubmitValidate()
    {
        searchFor = currentSearch;
        currentSearch = new ValidSearch();
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
