#pragma checksum "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceada558bdddc2f4a17117c11c5cbe15e7550237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Edit), @"mvc.1.0.view", @"/Views/Categories/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceada558bdddc2f4a17117c11c5cbe15e7550237", @"/Views/Categories/Edit.cshtml")]
    public class Views_Categories_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this category: ");
#nullable restore
#line 9 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
Write(Html.HiddenFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 19 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 20 "C:\Users\Becket\Desktop\ToDoList.Solutions\ToDoList\Views\Categories\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
