#pragma checksum "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8d011cc45e0261b508d308530df14c42c1687d2"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3_version_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using CA3_version_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\_Imports.razor"
using CA3_version_2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Crypto pairs App</h2>\r\n");
            __builder.AddMarkupContent(1, "<h3>The application that will let you explore more about the crypto world.</h3>\r\n<br>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>\r\n    This component will let you know the price of some cryptocurrency pairs thanks to n.exchange api.\r\n</p>\r\n");
            __builder.AddMarkupContent(3, @"<p>
    Cryptocurrency pairs are assets that can be traded for each other
    on an exchange  — for example Bitcoin/Litecoin (BTC/LTC) and Ethereum/Bitcoin Cash (ETH/BCH).
    Trading pairs lets you compare costs between different cryptocurrencies.
</p>");
#nullable restore
#line 18 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
 if (pairs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddMarkupContent(9, "<label>Base</label>\r\n            ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "custom-select custom-select-sm");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                   selectedBase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedBase = __value, selectedBase));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(14, "option");
            __builder.AddAttribute(15, "selected");
            __builder.AddAttribute(16, "value", "default");
            __builder.AddContent(17, "Open this select menu");
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                 foreach (var p in allbases)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "option");
            __builder.AddAttribute(19, "value", 
#nullable restore
#line 32 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                    p

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, 
#nullable restore
#line 32 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                        p

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col");
            __builder.AddMarkupContent(24, "<label>Quote</label>\r\n            ");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "class", "custom-select custom-select-sm");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                   selectedQuote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedQuote = __value, selectedQuote));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "selected");
            __builder.AddAttribute(31, "value", "default");
            __builder.AddContent(32, "Open this select menu");
            __builder.CloseElement();
#nullable restore
#line 43 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                 foreach (var q in allquotes)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", 
#nullable restore
#line 45 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                    q

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, 
#nullable restore
#line 45 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                        q

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col mt-4");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                     getPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Get pair price");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "style", "color:red");
            __builder.AddContent(49, 
#nullable restore
#line 59 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                      errorLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "row");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "col");
            __builder.OpenElement(54, "label");
            __builder.AddContent(55, 
#nullable restore
#line 65 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                    price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "row");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col");
            __builder.OpenElement(60, "label");
            __builder.AddContent(61, 
#nullable restore
#line 71 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                    explanation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col");
            __builder.OpenElement(66, "button");
            __builder.AddAttribute(67, "class", "btn btn-primary");
            __builder.AddAttribute(68, "style", 
#nullable restore
#line 77 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                    invisibleCSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                            showInputs

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "Open calculator");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col");
            __builder.OpenElement(75, "label");
            __builder.AddAttribute(76, "class", " mt-2");
            __builder.AddAttribute(77, "style", 
#nullable restore
#line 83 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                         invisibleCSS2

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, "Type how much base or quote would you like to get and it will calculate the other (Note: use \" . \" for decimal numbers):");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "row");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "input-group mt-2");
            __builder.AddAttribute(85, "style", "width:200px;" + " " + (
#nullable restore
#line 89 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                               invisibleCSS2

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "input-group-prepend");
            __builder.OpenElement(88, "span");
            __builder.AddAttribute(89, "class", "input-group-text");
            __builder.AddContent(90, 
#nullable restore
#line 91 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                    selectedBase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "type", "text");
            __builder.AddAttribute(94, "class", "form-control");
            __builder.AddAttribute(95, "oninput", "this.value = this.value.replace(/[^0-9.]/g, \'\').replace(/(\\..*)\\./g, \'$1\');");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                inputBase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputBase = __value, inputBase));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\r\n            ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "input-group mt-2");
            __builder.AddAttribute(101, "style", "width:200px;" + " " + (
#nullable restore
#line 96 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                               invisibleCSS2

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "input-group-prepend");
            __builder.OpenElement(104, "span");
            __builder.AddAttribute(105, "class", "input-group-text");
            __builder.AddContent(106, 
#nullable restore
#line 98 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                    selectedQuote

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "input");
            __builder.AddAttribute(109, "type", "text");
            __builder.AddAttribute(110, "class", "form-control");
            __builder.AddAttribute(111, "oninput", "this.value = this.value.replace(/[^0-9.]/g, \'\').replace(/(\\..*)\\./g, \'$1\');");
            __builder.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                inputQuote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inputQuote = __value, inputQuote));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n\r\n            ");
            __builder.OpenElement(115, "button");
            __builder.AddAttribute(116, "class", "btn btn-primary mt-4");
            __builder.AddAttribute(117, "style", 
#nullable restore
#line 103 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                         invisibleCSS2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                                  calculatePrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(119, "Calculate");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "row");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "col");
            __builder.OpenElement(124, "label");
            __builder.AddAttribute(125, "class", "mt-2");
            __builder.AddAttribute(126, "style", "color:red;" + " " + (
#nullable restore
#line 111 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                    invisibleCSS2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(127, 
#nullable restore
#line 111 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                                                                    errorLabel2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "row");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col");
            __builder.OpenElement(132, "label");
            __builder.AddContent(133, 
#nullable restore
#line 117 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
                    explanation2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 120 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\ernes\Desktop\TUD\Enterprise Applications Development\CA3\CA3EAD\CA3 version 2\Pages\Index.razor"
       
    private Pairs[] pairs;
    private Cost cost;
    private Cost cost2;
    private List<String> allbases;
    private List<String> allquotes;
    private string selectedBase;
    private string selectedQuote;
    private string errorLabel;
    private string errorLabel2;
    private string price;
    private string explanation;
    private string explanation2;
    private string invisibleCSS;
    private string invisibleCSS2;
    private string inputBase;
    private string inputQuote;


    protected override async Task OnInitializedAsync()
    {

        pairs = await Http.GetFromJsonAsync<Pairs[]>("https://api.n.exchange/en/api/v1/pair/");

        errorLabel = "";
        errorLabel2 = "";
        price = "";

        allbases = new List<String>();
        allBase();

        allquotes = new List<String>();
        allQuote();

        invisibleCSS = "display: none";
        invisibleCSS2 = "display: none";

        //https://api.n.exchange/en/api/v1/get_price/BTCLTC/?amount_base=1.06935074&amount_quote=100
    }

    public class Pairs
    {
        public string Name { get; set; }
        public string @Base { get; set; }
        public string Quote { get; set; }
        public string Fee_ask { get; set; }
        public string Fee_bid { get; set; }
        public bool Disabled { get; set; }
        public bool Test_mode { get; set; }
        public bool Orderbook_enabled { get; set; }
        public bool Reverse_orderbook_enabled { get; set; }
    }

    public class Pair
    {
        public string @Base { get; set; }
        public string Quote { get; set; }
    }

    public class Cost
    {
        public double Amount_base { get; set; }
        public double Amount_quote { get; set; }
        public double Timestamp { get; set; }
        public double Price { get; set; }
        public Pair Pair { get; set; }
        public double Max_amount_base { get; set; }
        public double Max_amount_quote { get; set; }
        public double Min_amount_base { get; set; }
        public double Min_amount_quote { get; set; }
    }

    public void allBase()
    {

        for (int j = 0; j < pairs.Length; j++)
        {
            if (allbases.Count == 0)
            {
                allbases.Add(pairs[j].Base);
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < allbases.Count; i++)
                {
                    if (pairs[j].Base == allbases[i])
                    {
                        flag = false;
                    }
                }
                if (flag) { allbases.Add(pairs[j].Base); }
            }
        }

    }

    public void allQuote()
    {
        for (int j = 0; j < pairs.Length; j++)
        {
            if (allquotes.Count == 0)
            {
                allquotes.Add(pairs[j].Quote);
            }
            else
            {
                bool flag = true;
                for (int i = 0; i < allquotes.Count; i++)
                {

                    if (pairs[j].Quote == allquotes[i])
                    {
                        flag = false;
                    }
                }
                if (flag) { allquotes.Add(pairs[j].Quote); }
            }
        }

    }

    public async Task getPrice()
    {
        errorLabel = "";
        price = "";
        explanation = "";

        if (selectedBase == null || selectedQuote == null || selectedBase == "default" || selectedQuote == "default")
        {
            errorLabel = "You must select a base and a quote before getting the price.";
        }
        else
        {
            try {
                string url = "https://api.n.exchange/en/api/v1/get_price/" + selectedBase + selectedQuote + "/";
                cost = await Http.GetFromJsonAsync<Cost>(url);
                DateTime d = UnixTimeStampToDateTime(cost.Timestamp);
                price = "The price of the selected pair is: " + cost.Price.ToString() + " (Last updated: " + d.ToString() + ").";
                explanation = "This means that in order to buy one " + selectedBase + " coin, you must spend " + cost.Price.ToString() + " " + selectedQuote + ".";
                invisibleCSS = "";
            }
            catch (Exception e) {
                errorLabel = "The API returned 400 bad request. Try again or change any of the cryptocurrencies.";
            }
        }
    }

    public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
    {
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
        return dateTime;
    }

    public void showInputs()
    {
        invisibleCSS2 = "";
    }

    public async Task calculatePrice()
    {

        errorLabel2 = "";
        explanation2 = "";

        if ((inputBase == null && inputQuote == null) || (inputBase == "" && inputQuote == "") || (inputBase == null && inputQuote == "") || (inputBase == "" && inputQuote == null))
        {
            errorLabel2 = "You must select either base quantity or a quote quantity.";
        }
        else
        {
            try {
                if (inputQuote == "" || inputQuote == null)
                {
                    string amountBase = "amount_base=" + inputBase;
                    string url = "https://api.n.exchange/en/api/v1/get_price/" + selectedBase + selectedQuote + "/?" + amountBase;
                    cost2 = await Http.GetFromJsonAsync<Cost>(url);
                    explanation2 = "For the amount of " + inputBase + " " + selectedBase + " you must spend " + cost2.Amount_quote.ToString() + " " + selectedQuote;
                }
                else
                {
                    if (inputBase == "" || inputBase == null)
                    {
                        string amountQuote = "amount_quote=" + inputQuote;
                        string url = "https://api.n.exchange/en/api/v1/get_price/" + selectedBase + selectedQuote + "/?" + amountQuote;
                        cost2 = await Http.GetFromJsonAsync<Cost>(url);
                        explanation2 = "For the amount of " + inputQuote + " " + selectedQuote + " you must spend " + cost2.Amount_base.ToString() + " " + selectedBase;
                    }
                    else
                    {
                        errorLabel2 = "You must select either a base quantity or a quote quantity, not both.";
                    }
                }
            }
            catch (Exception e){
                errorLabel2 = "The API returned 400 bad request. Try again or use smaller/bigger quantities.";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
