#pragma checksum "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ae63369dee413b996316ccff0fcc45d09c1e1fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_List_Default), @"mvc.1.0.view", @"/Views/Home/Components/List/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/List/Default.cshtml", typeof(AspNetCore.Views_Home_Components_List_Default))]
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
#line 1 "/Users/Andrew/Projects/ListDemo/Views/_ViewImports.cshtml"
using ListDemo;

#line default
#line hidden
#line 2 "/Users/Andrew/Projects/ListDemo/Views/_ViewImports.cshtml"
using ListDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ae63369dee413b996316ccff0fcc45d09c1e1fe", @"/Views/Home/Components/List/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc3d93ee2fb8e222e839b4956b8674fee278986", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_List_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ListDemo.Models.ListItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 28, true);
            WriteLiteral("\n<ul id=\"list\" class=\"col\">\n");
            EndContext();
#line 4 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
     foreach(ListDemo.Models.ListItem movie in Model){

#line default
#line hidden
            BeginContext(121, 23, true);
            WriteLiteral("        <li class=\"row\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 144, "\"", 227, 10);
            WriteAttributeValue("", 154, "app.listItemClick(\'", 154, 19, true);
#line 5 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
WriteAttributeValue("", 173, movie.Id, 173, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 182, "\',", 182, 2, true);
            WriteAttributeValue(" ", 184, "\'", 185, 2, true);
#line 5 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
WriteAttributeValue("", 186, movie.Url, 186, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 196, "\',", 196, 2, true);
#line 5 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
WriteAttributeValue(" ", 198, movie.Element, 199, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 213, ",", 213, 1, true);
            WriteAttributeValue(" ", 214, "this,", 215, 6, true);
            WriteAttributeValue(" ", 220, "event)", 221, 7, true);
            EndWriteAttribute();
            BeginContext(228, 91, true);
            WriteLiteral(">\n            <div class=\"col\">\n                <div class=\"row text\">\n                    ");
            EndContext();
            BeginContext(320, 10, false);
#line 8 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
               Write(movie.Text);

#line default
#line hidden
            EndContext();
            BeginContext(330, 87, true);
            WriteLiteral("\n                </div>\n                <div class=\"row sub-text\">\n                    ");
            EndContext();
            BeginContext(418, 13, false);
#line 11 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
               Write(movie.SubText);

#line default
#line hidden
            EndContext();
            BeginContext(431, 57, true);
            WriteLiteral("\n                </div>\n            </div>\n        </li>\n");
            EndContext();
#line 15 "/Users/Andrew/Projects/ListDemo/Views/Home/Components/List/Default.cshtml"
    }

#line default
#line hidden
            BeginContext(494, 6, true);
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ListDemo.Models.ListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
