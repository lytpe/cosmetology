#pragma checksum "d:\Cosmetology\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d32560f7a762ba4a7eda6b00a0174dabb3c2244"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "d:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology;

#line default
#line hidden
#line 2 "d:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d32560f7a762ba4a7eda6b00a0174dabb3c2244", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "d:\Cosmetology\Views\Home\About.cshtml"
  
	ViewData["Title"]="关于我们";

#line default
#line hidden
            BeginContext(32, 2002, true);
            WriteLiteral(@"<div class=""container"">
	<br/><br/>
	<div class=""row"" id=""aboutModelone""></div>
	<br/><br/>
	<div class=""row"">
		<div class=""col-md-6 col-sm-12 col-lg-6 history-grid-left"" id=""aboutModeltwo""></div>
		<div class=""col-md-6 col-sm-12 col-lg-6 history-grid-right"" id=""aboutModelthree""></div>
	</div>
	<br/><br/>
</div>
<script>
	$.ajax({
		url:'showAboutModelOne',
		type:'POST',
		dataType:'Json',
		contentType:""application/json"",
		success:function(data, textStatus){
			var articles=data.articles;
			var htm="""";
			for(var i=0;i<articles.length;i++){
				htm+=""<div class='col-sm-6 col-md-3 col-lg-3'><div class='banner-bottom-grid1'><h1>""+articles[i].articleName+""</h1><p>""+articles[i].articleSideName+""</p><div class='more'><a href='Single?id=""+articles[i].id+""' class='hvr-curl-bottom-right'>Read More...</a></div></div></div>"";
			}
			$(""#aboutModelone"").append(htm);
		},
		error:function(){
			console.log(""请求失败！"");
		}
	});
		$.ajax({
		url:'showAboutModelTwo',
		type:'POST',
		dataType:'Json',
		contentType:""appl");
            WriteLiteral(@"ication/json"",
		success:function(data, textStatus){
			var articles=data.articles;
			var htm=""<h3>""+articles[0].articleName+""</h3><p>""+articles[0].articleContext+""</p>""+
					""<img src='""+articles[0].articleImgUrl+""' alt='' class='img-responsive'/>"";
			$(""#aboutModeltwo"").append(htm);
		},
		error:function(){
			console.log(""请求失败！"");
		}
	});
		$.ajax({
		url:'showAboutModelThree',
		type:'POST',
		dataType:'Json',
		contentType:""application/json"",
		success:function(data, textStatus){
			var articles=data.articles;
			var htm=""<h3>Testimonials</h3><br/>"";
			for(var i=0;i<articles.length;i++){
				htm+=""<div class='row'><div class='col-sm-4 col-md-4 col-lg-4'>""+
						""<img src='""+articles[i].articleImgUrl+""' alt='' class='img-responsive'/>""+
						""</div><div class='col-sm-8 col-md-8 col-lg-8'><p>""+articles[i].articleContext+""</p></div></div><br/>"";
			}
			$(""#aboutModelthree"").append(htm);
		},
		error:function(){
			console.log(""请求失败！"");
		}
	});
</script>");
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
