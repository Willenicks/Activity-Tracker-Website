#pragma checksum "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be1192807aa79e5f5be9f95776ac27374fd6424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ActivityRecord_Details), @"mvc.1.0.view", @"/Views/ActivityRecord/Details.cshtml")]
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
#line 1 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\_ViewImports.cshtml"
using Project_Step_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\_ViewImports.cshtml"
using Project_Step_9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be1192807aa79e5f5be9f95776ac27374fd6424", @"/Views/ActivityRecord/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e22412fed0df31a420501a784dfec537fd11a0f0", @"/Views/_ViewImports.cshtml")]
    public class Views_ActivityRecord_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityRecord>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1> Activity Record </h1>\r\n\r\nRecord number: ");
#nullable restore
#line 5 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml"
          Write(Model.RecordID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\nId: ");
#nullable restore
#line 6 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml"
Write(Model.ActivityId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\nDate: ");
#nullable restore
#line 7 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml"
 Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\nLocation: ");
#nullable restore
#line 8 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml"
     Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\nDistance: ");
#nullable restore
#line 9 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml"
     Write(Model.Distance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\nTime: ");
#nullable restore
#line 10 "C:\Users\wheni\source\repos\422\Final Project\Project Step 10\Project Step 9\Views\ActivityRecord\Details.cshtml"
 Write(Model.TimeRecord);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be1192807aa79e5f5be9f95776ac27374fd64245532", async() => {
                WriteLiteral(" Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityRecord> Html { get; private set; }
    }
}
#pragma warning restore 1591
