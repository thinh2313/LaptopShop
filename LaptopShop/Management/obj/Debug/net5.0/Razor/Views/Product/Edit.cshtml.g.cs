#pragma checksum "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e3b05c1e6c5a61fe2f8aab0c3db6c66f0bb59c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
#line 1 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\_ViewImports.cshtml"
using Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3b05c1e6c5a61fe2f8aab0c3db6c66f0bb59c", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78fff7de114e5d368bcb520556b8ec07f96d2d1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Management.ViewModel.Product.UpdateProductInput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
     using (Html.BeginForm("Create", "Product", FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 5 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 6 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 7 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.LabelFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 8 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.EditorFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 9 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.LabelFor(m => m.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 10 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.EditorFor(m => m.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 11 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 12 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.EditorFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <label>");
#nullable restore
#line 15 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
              Write(Html.LabelFor(m => m.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            <p>\r\n                ");
#nullable restore
#line 17 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
           Write(Html.DropDownList("CategoryName", (IEnumerable<SelectListItem>)ViewBag.Categories, new { @class = "form -control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <p>");
#nullable restore
#line 20 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
      Write(Html.HiddenFor(m => m.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"form-group\">\r\n            <label>");
#nullable restore
#line 22 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
              Write(Html.LabelFor(m => m.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>          \r\n            <p> <img");
            BeginWriteAttribute("src", " src=\"", 1013, "\"", 1044, 1);
#nullable restore
#line 23 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1019, Url.Content(Model.Image), 1019, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\" width=\"250\"");
            BeginWriteAttribute("alt", " alt=\"", 1070, "\"", 1076, 0);
            EndWriteAttribute();
            WriteLiteral(" /> </p> \r\n           <input type=\"file\" id=\"file\" name=\"UploadImage\" style=\"width:100%;\" />\r\n        </div>\r\n        <div>\r\n            <input type=\"submit\" value=\"create\" />\r\n            <span class=\"btn btn-link\">");
#nullable restore
#line 28 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
                                  Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n        </div>\r\n");
#nullable restore
#line 30 "H:\năm 4\Website LaptopShop\LaptopShop\LaptopShop\Management\Views\Product\Edit.cshtml"
        
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Management.ViewModel.Product.UpdateProductInput> Html { get; private set; }
    }
}
#pragma warning restore 1591
