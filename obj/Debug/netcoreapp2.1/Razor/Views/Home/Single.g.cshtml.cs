#pragma checksum "d:\Cosmetology\Views\Home\Single.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d709cfb5789aa5d41caf147f46a65ed596a1a73e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Single), @"mvc.1.0.view", @"/Views/Home/Single.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Single.cshtml", typeof(AspNetCore.Views_Home_Single))]
namespace AspNetCore
{
    #line hidden
#line 1 "d:\Cosmetology\Views\Home\Single.cshtml"
using System;

#line default
#line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "d:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology;

#line default
#line hidden
#line 2 "d:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d709cfb5789aa5d41caf147f46a65ed596a1a73e", @"/Views/Home/Single.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Single : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cosmetology.Models.Articles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "d:\Cosmetology\Views\Home\Single.cshtml"
  
	ViewData["Title"]="内容";

#line default
#line hidden
            BeginContext(80, 85, true);
            WriteLiteral("\t<div class=\"single\">\n\t\t\t<div class=\"col-md-10 col-md-offset-1 single-left\">\n\t\t\t\t<h3>");
            EndContext();
            BeginContext(166, 17, false);
#line 8 "d:\Cosmetology\Views\Home\Single.cshtml"
               Write(Model.ArticleName);

#line default
#line hidden
            EndContext();
            BeginContext(183, 94, true);
            WriteLiteral("</h3>\n\t\t\t\t<ul>\n\t\t\t\t\t<li><span class=\"glyphicon glyphicon-calendar\" aria-hidden=\"true\"></span> ");
            EndContext();
            BeginContext(278, 23, false);
#line 10 "d:\Cosmetology\Views\Home\Single.cshtml"
                                                                                         Write(Model.ArticleUpdateDate);

#line default
#line hidden
            EndContext();
            BeginContext(301, 93, true);
            WriteLiteral("</li>\n\t\t\t\t\t<li><a href=\"#\"><span class=\"glyphicon glyphicon-user\" aria-hidden=\"true\"></span> ");
            EndContext();
            BeginContext(395, 14, false);
#line 11 "d:\Cosmetology\Views\Home\Single.cshtml"
                                                                                                 Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(409, 20, true);
            WriteLiteral("</a></li>\n\t\t\t\t</ul>\n");
            EndContext();
#line 13 "d:\Cosmetology\Views\Home\Single.cshtml"
                  
					string url="";
					 if(@Model.ArticleImgUrl!=null){
					    url=@Model.ArticleImgUrl.Remove(0,22);
					 }
					 else{
					    url="";
					 }
				

#line default
#line hidden
            BeginContext(593, 8, true);
            WriteLiteral("\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 601, "\"", 611, 1);
#line 22 "d:\Cosmetology\Views\Home\Single.cshtml"
WriteAttributeValue("", 607, url, 607, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(612, 42, true);
            WriteLiteral(" alt=\"\"  class=\"img-responsive\" />\n\t\t\t\t<p>");
            EndContext();
            BeginContext(655, 20, false);
#line 23 "d:\Cosmetology\Views\Home\Single.cshtml"
              Write(Model.ArticleContext);

#line default
#line hidden
            EndContext();
            BeginContext(675, 580, true);
            WriteLiteral(@"
					<i>I will give you a complete account of the system, and 
						expound the actual teachings of the great explorer of the truth.</i>
					<span>But I must explain to you how all this mistaken idea of denouncing pleasure 
						and praising pain was born and I will give you a complete account of the system, and 
						expound the actual teachings of the great explorer of the truth, the master-builder 
						of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it 
						is pleasure</span></p>
			</div>
			<div class=""clearfix""> </div>
	</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cosmetology.Models.Articles> Html { get; private set; }
    }
}
#pragma warning restore 1591
