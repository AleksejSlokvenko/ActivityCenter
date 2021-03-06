#pragma checksum "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2590c751671eda5606930e93f45f5ccc15285f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActivityDisplay), @"mvc.1.0.view", @"/Views/Home/ActivityDisplay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ActivityDisplay.cshtml", typeof(AspNetCore.Views_Home_ActivityDisplay))]
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
#line 1 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2590c751671eda5606930e93f45f5ccc15285f3", @"/Views/Home/ActivityDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActivityDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Occasion>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 376, true);
            WriteLiteral(@"<nav class=""navbar sticky-top navbar-default mb-5"">
    <a class=""navbar-brand ""><h2>Welcome to the Activity Center!</h2></a>
    <div class=""navbar-brand"">
        <a class=""navbar-brand"" href=""/dashboard""> Home </a>
        <a class=""navbar-brand"" href=""logout""> Logout </a>
    </div>
</nav>
<hr>
<div class=""container"">
    <div class=""d-flex flex-row-reverse"">
");
            EndContext();
#line 12 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
          
            bool isGoing = false;
            foreach(var g in ViewBag.a.Attendees) {
                if(g.UserId == ViewBag.u.UserId) {
                    isGoing = true;
                }
            }
            if( ViewBag.a.Coordinator.UserId == ViewBag.u.UserId && isGoing) {

#line default
#line hidden
            BeginContext(696, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 714, "\"", 750, 2);
            WriteAttributeValue("", 721, "/delete/", 721, 8, true);
#line 20 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
WriteAttributeValue("", 729, ViewBag.a.OccasionId, 729, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(751, 38, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>  \r\n");
            EndContext();
#line 21 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
            } else if (isGoing && ViewBag.a.Coordinator.UserId != ViewBag.u.UserId) {

#line default
#line hidden
            BeginContext(876, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 894, "\"", 947, 4);
            WriteAttributeValue("", 901, "/leave/", 901, 7, true);
#line 22 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
WriteAttributeValue("", 908, ViewBag.a.OccasionId, 908, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 929, "/", 929, 1, true);
#line 22 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
WriteAttributeValue("", 930, ViewBag.u.UserId, 930, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(948, 38, true);
            WriteLiteral(" class=\"btn btn-primary\">Leave</a>  \r\n");
            EndContext();
#line 23 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
            } else {

#line default
#line hidden
            BeginContext(1008, 18, true);
            WriteLiteral("                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1078, 4);
            WriteAttributeValue("", 1033, "/join/", 1033, 6, true);
#line 24 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
WriteAttributeValue("", 1039, ViewBag.a.OccasionId, 1039, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1060, "/", 1060, 1, true);
#line 24 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
WriteAttributeValue("", 1061, ViewBag.u.UserId, 1061, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1079, 39, true);
            WriteLiteral(" class=\"btn btn-success\">Join</a>    \r\n");
            EndContext();
#line 25 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1144, 33, true);
            WriteLiteral("    </div>\r\n    <h1 class=\"mb-5\">");
            EndContext();
            BeginContext(1178, 15, false);
#line 28 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
                Write(ViewBag.a.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 47, true);
            WriteLiteral("</h1>\r\n    <h6 class=\"mb-5\">Event Coordinator: ");
            EndContext();
            BeginContext(1241, 26, false);
#line 29 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
                                   Write(ViewBag.a.Coordinator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1267, 66, true);
            WriteLiteral("</h6>\r\n    <h3 class=\"display-lead\">Description:</h3><br>\r\n    <p>");
            EndContext();
            BeginContext(1334, 21, false);
#line 31 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
  Write(ViewBag.a.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1355, 70, true);
            WriteLiteral("</p>\r\n    <hr>\r\n    <h3 class=\"display-lead mb-5\">Participants:</h3>\r\n");
            EndContext();
#line 34 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
     foreach(var a in ViewBag.a.Attendees)
    {

#line default
#line hidden
            BeginContext(1476, 21, true);
            WriteLiteral("        <li class=\"\">");
            EndContext();
            BeginContext(1498, 17, false);
#line 36 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
                Write(a.SingleUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1515, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 37 "C:\Users\isnow\Desktop\C#\ActivityCenter\Views\Home\ActivityDisplay.cshtml"
    }

#line default
#line hidden
            BeginContext(1529, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Occasion> Html { get; private set; }
    }
}
#pragma warning restore 1591
