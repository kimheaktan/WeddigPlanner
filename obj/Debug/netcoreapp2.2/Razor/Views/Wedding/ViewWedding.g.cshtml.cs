#pragma checksum "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71d4c67f578f7cf705a211d5928b0102701d44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_ViewWedding), @"mvc.1.0.view", @"/Views/Wedding/ViewWedding.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/ViewWedding.cshtml", typeof(AspNetCore.Views_Wedding_ViewWedding))]
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
#line 1 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71d4c67f578f7cf705a211d5928b0102701d44e", @"/Views/Wedding/ViewWedding.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_ViewWedding : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Weddings.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(20, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 3 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(60, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(64, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d71d4c67f578f7cf705a211d5928b0102701d44e5840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(113, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(117, 180, true);
            WriteLiteral("<nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\n            <div class=\"container\"> \n\n  <h2 class=\"col-auto mr-auto\">");
            EndContext();
            BeginContext(297, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71d4c67f578f7cf705a211d5928b0102701d44e7360", async() => {
                BeginContext(374, 90, true);
                WriteLiteral(" <img src=\"https://static.xx.fbcdn.net/rsrc.php/v3/yG/r/5kz8465R1Ag.png\" alt=\"\"> Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(468, 32, true);
            WriteLiteral("</h2>\n\n  <div class=\"col-auto\"> ");
            EndContext();
            BeginContext(500, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71d4c67f578f7cf705a211d5928b0102701d44e9314", async() => {
                BeginContext(547, 125, true);
                WriteLiteral("<img src=\"https://static.xx.fbcdn.net/rsrc.php/v3/yr/r/3yLx6d_XuYE.png\" width=\"28px\" alt=\"logo\" class=\"LogoColor text-muted\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(676, 139, true);
            WriteLiteral(" </div>\n</nav>\n\n<div class=\"container\">\n  <div class=\"card border-0 shadow my-5\">\n    <div class=\"card-body p-5\">\n\n<h1 class=\"Text-center\">");
            EndContext();
            BeginContext(816, 15, false);
#line 20 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
                   Write(Model.Wedders());

#line default
#line hidden
            EndContext();
            BeginContext(831, 26, true);
            WriteLiteral("</h1>\n\n<p>Wedding\'s date: ");
            EndContext();
            BeginContext(858, 34, false);
#line 22 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
              Write(Model.Date.ToString("MMM-dd-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(892, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(897, 24, false);
#line 22 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
                                                     Write(Model.Date.ToString("t"));

#line default
#line hidden
            EndContext();
            BeginContext(921, 17, true);
            WriteLiteral("</p>\n<p>Address: ");
            EndContext();
            BeginContext(939, 15, false);
#line 23 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
       Write(Model.Address());

#line default
#line hidden
            EndContext();
            BeginContext(954, 22, true);
            WriteLiteral("</p>\n\n<div>Attendees: ");
            EndContext();
            BeginContext(977, 21, false);
#line 25 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
           Write(Model.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(998, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 27 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
     foreach (var user in Model.Attendees)
    {

#line default
#line hidden
            BeginContext(1049, 16, true);
            WriteLiteral("        <p></p>\n");
            EndContext();
#line 30 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
        if(@user.User.UserId == @Model.CreatorId)
        {

#line default
#line hidden
            BeginContext(1125, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(1141, 20, false);
#line 32 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
          Write(user.User.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(1161, 19, true);
            WriteLiteral(" (Coordinator)</p>\n");
            EndContext();
#line 33 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1213, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(1229, 20, false);
#line 36 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
          Write(user.User.FullName());

#line default
#line hidden
            EndContext();
            BeginContext(1249, 14, true);
            WriteLiteral(" (Guests)</p>\n");
            EndContext();
#line 37 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1279, 175, true);
            WriteLiteral("</div>\n\n<div class=\"center\">\n<div class=\"col-9 d-flex flex-wrap justify-content-cente\">\n        <iframe width=\"600\" height=\"450\" frameborder=\"1\" style=\"border:1px solid grey;\"");
            EndContext();
            BeginWriteAttribute("src", " \n        src=\"", 1454, "\"", 1607, 8);
            WriteAttributeValue("", 1469, "https://www.google.com/maps/embed/v1/place?key=AIzaSyBcbGOQQ4Zk3sFgmqmGCEA-H_r7tnlglwk&q=", 1469, 89, true);
#line 44 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1558, Model.Street, 1558, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1571, "+", 1571, 1, true);
#line 44 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1572, Model.City, 1572, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1583, "+", 1583, 1, true);
#line 44 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1584, Model.State, 1584, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1596, "+", 1596, 1, true);
#line 44 "/Users/user/coding dojo/job/projects/WeddingPlanner/Views/Wedding/ViewWedding.cshtml"
WriteAttributeValue("", 1597, Model.Zip, 1597, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1608, 79, true);
            WriteLiteral(" \n        allowfullscreen></iframe>\n      </div>\n</div>\n\n</div>\n  </div>\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
