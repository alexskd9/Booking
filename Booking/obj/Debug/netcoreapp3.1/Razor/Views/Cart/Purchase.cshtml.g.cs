#pragma checksum "C:\Users\Alex\Desktop\Booking\Booking\Views\Cart\Purchase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9d53bd8f7c3e85e3ae0e94ef2b9ccd31c3285b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Purchase), @"mvc.1.0.view", @"/Views/Cart/Purchase.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9d53bd8f7c3e85e3ae0e94ef2b9ccd31c3285b", @"/Views/Cart/Purchase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cb8ea961cb0ab3563b2a23336f52fa904a03b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Purchase : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking.Models.PurchaseClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alex\Desktop\Booking\Booking\Views\Cart\Purchase.cshtml"
  
    ViewData["Title"] = "შეძენა";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>შეძენა</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc9d53bd8f7c3e85e3ae0e94ef2b9ccd31c3285b3998", async() => {
                WriteLiteral("\r\n    <span style=\"font-size:20px\">გადაამოწმეთ თქვენი მონაცემები და დააჭირეთ შეძენის ღილაკს</span>\r\n    <div class=\"form-group\">\r\n        <p>სახელი: ");
#nullable restore
#line 11 "C:\Users\Alex\Desktop\Booking\Booking\Views\Cart\Purchase.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>გვარი: ");
#nullable restore
#line 12 "C:\Users\Alex\Desktop\Booking\Booking\Views\Cart\Purchase.cshtml"
             Write(Model.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p style=\"font-size:20px\"><span style=\"font-size:20px; margin-right:5px\">თანხა: </span><strong>");
#nullable restore
#line 13 "C:\Users\Alex\Desktop\Booking\Booking\Views\Cart\Purchase.cshtml"
                                                                                                  Write(Math.Round(Model.TotalAmount, 2));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ₾</strong></p>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" class=\"btn btn-success\" value=\"შეძენა\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking.Models.PurchaseClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
