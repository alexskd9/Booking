#pragma checksum "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7fce77093b275a5b6979625d599feadb61984f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Details), @"mvc.1.0.view", @"/Views/Event/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alex\Desktop\Booking\Booking\Views\_ViewImports.cshtml"
using Booking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alex\Desktop\Booking\Booking\Views\_ViewImports.cshtml"
using Booking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c7fce77093b275a5b6979625d599feadb61984f", @"/Views/Event/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb8ea961cb0ab3563b2a23336f52fa904a03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking.Models.EventExtended>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AddToCart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
  
    ViewData["Title"] = "დეტალები";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.5.0.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7fce77093b275a5b6979625d599feadb61984f4432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
Write(Model.Events.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>");
#nullable restore
#line 9 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
Write(Model.Events.EventDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ფასი: ");
#nullable restore
#line 10 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
    Write(Math.Round(Model.Events.TicketPrice, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₾</p>\r\n\r\n<table class=\"table table-bordered\">\r\n");
#nullable restore
#line 13 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
      
        if (User.Identity.IsAuthenticated)
        {
            for (int i = 1; i < ViewBag.RowNumber + 1; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 19 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
                      
                        foreach (var item in Model.EventPlaces.Where(x=>x.Row == i))
                        {
                            if (item.IsAvailable == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><input class=\"AddToCart\" type=\"submit\" style=\"border:none; width:100%\" data-placeId=\"");
#nullable restore
#line 24 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
                                                                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-eventId=\"");
#nullable restore
#line 24 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
                                                                                                                                            Write(item.EventId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("value", " value=\"", 927, "\"", 952, 1);
#nullable restore
#line 24 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
WriteAttributeValue("", 935, item.PlaceNumber, 935, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 25 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><input type=\"submit\" style=\"border:none; width:100%; background-color:red\" data-placeId=\"");
#nullable restore
#line 28 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" disabled");
            BeginWriteAttribute("value", " value=\"", 1202, "\"", 1227, 1);
#nullable restore
#line 28 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
WriteAttributeValue("", 1210, item.PlaceNumber, 1210, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n");
#nullable restore
#line 29 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>ბილეთების დასაჯავშნად გთხოვთ ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c7fce77093b275a5b6979625d599feadb61984f9773", async() => {
                WriteLiteral("შეხვიდეთ სისტემაში");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n");
#nullable restore
#line 38 "C:\Users\Alex\Desktop\Booking\Booking\Views\Event\Details.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking.Models.EventExtended> Html { get; private set; }
    }
}
#pragma warning restore 1591