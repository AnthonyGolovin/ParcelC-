#pragma checksum "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e849821b1b60e439040408117bf112db627c4061"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Index.cshtml", typeof(AspNetCore.Views_Categories_Index))]
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
#line 5 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e849821b1b60e439040408117bf112db627c4061", @"/Views/Categories/Index.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(52, 22, true);
            WriteLiteral("\n<h1>Categories</h1>\n\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(100, 46, true);
            WriteLiteral("  <h3>No categories have been added yet!</h3>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(149, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
 foreach (Category category in Model)
{

#line default
#line hidden
            BeginContext(190, 8, true);
            WriteLiteral("  <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 198, "\'", 229, 2);
            WriteAttributeValue("", 205, "/categories/", 205, 12, true);
#line 16 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
WriteAttributeValue("", 217, category.Id, 217, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(230, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(232, 13, false);
#line 16 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
                                    Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(245, 10, true);
            WriteLiteral("</a></h3>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/ParcelsFolder/Parcel/Views/Categories/Index.cshtml"
}

#line default
#line hidden
            BeginContext(257, 33, true);
            WriteLiteral("\n<p><a href=\'/\'>Back home</a></p>");
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
