#pragma checksum "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Items/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3bfb237d4c2092bc4b3692a01860bbf8c00278e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_New), @"mvc.1.0.view", @"/Views/Items/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/New.cshtml", typeof(AspNetCore.Views_Items_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3bfb237d4c2092bc4b3692a01860bbf8c00278e", @"/Views/Items/New.cshtml")]
    public class Views_Items_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Items/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 23, true);
            WriteLiteral("\n<h1>Add a new item to ");
            EndContext();
            BeginContext(51, 10, false);
#line 5 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Items/New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(61, 12, true);
            WriteLiteral("</h1>\n\n<form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 73, "\"", 109, 3);
            WriteAttributeValue("", 82, "/categories/", 82, 12, true);
#line 7 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Items/New.cshtml"
WriteAttributeValue("", 94, Model.Id, 94, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 103, "/items", 103, 6, true);
            EndWriteAttribute();
            BeginContext(110, 72, true);
            WriteLiteral(" method=\"post\">\n  <input id=\"categoryId\" name=\"categoryId\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 182, "\"", 199, 1);
#line 8 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Items/New.cshtml"
WriteAttributeValue("", 190, Model.Id, 190, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(200, 173, true);
            WriteLiteral(">\n  <label for=\"itemDescription\">Item Description</label>\n  <input id=\"itemDescription\" name=\"itemDescription\" type=\"text\">\n  <button type=\'submit\'>Add item</button>\n</form>");
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
