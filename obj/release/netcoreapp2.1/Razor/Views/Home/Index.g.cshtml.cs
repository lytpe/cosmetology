#pragma checksum "D:\Cosmetology\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8d61fac4fc38d5cb318c16fc90e9a29cab8eefc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology;

#line default
#line hidden
#line 2 "D:\Cosmetology\Views\_ViewImports.cshtml"
using Cosmetology.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d61fac4fc38d5cb318c16fc90e9a29cab8eefc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Cosmetology\Views\Home\Index.cshtml"
  
	ViewData["Title"]="首页";

#line default
#line hidden
            BeginContext(30, 3346, true);
            WriteLiteral(@"<div class=""container"">
	<div id=""myCarousel"" class=""carousel slide"">
		<ol class=""carousel-indicators"">
			<li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
			<li data-target=""#myCarousel"" data-slide-to=""1""></li>
			<li data-target=""#myCarousel"" data-slide-to=""2""></li>
		</ol>   
		<div class=""carousel-inner"" id=""bigpic"">
		</div>
		<a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
			<span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
			<span class=""sr-only"">Previous</span>
		</a>
		<a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
			<span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
			<span class=""sr-only"">Next</span>
		</a>
	</div>
	<br/>
	<div class=""row"" id=""IndexArticles""></div>
	<br/>
	<div class=""row"" >
			<div class=""col-sm-8 col-md-8 col-lg-8"" id=""pic""></div>
			<div class=""col-sm-4 col-md-4 col-lg-4"" id=""articlelists""></div>
	</div>
</div>
<script>
	$.ajax({
	");
            WriteLiteral(@"	url:'/Home/showBigPic',
		type:'POST',
		dataType:'Json',
		contentType:""application/json"",
		success:function(data, textStatus){
			var scrolls=data.scrolls;
			var htm=""<div class='item active'><img src='""+scrolls[0].imgUrl.slice(22,)+""' alt='First slide' class='img-responsive'></div>"";
			for(var i=1;i<scrolls.length;i++){
				htm+=""<div class='item'><img src='""+scrolls[i].imgUrl.slice(22,)+""' alt='First slide' class='img-responsive'></div>"";
			}
			$(""#bigpic"").append(htm);
		},
		error:function(){
			console.log(""请求失败!"");
		}
	});
	$.ajax({
		url:'/Home/showIndexModelOne',
		type:'POST',
		dataType:'Json',
		contentType:""application/json"",
		success:function(data, textStatus){
			var articles=data.articles;
			var htm="""";
			for(var i=0;i<articles.length;i++){
				htm+=""<div class='col-sm-6 col-md-3 col-lg-3'><div class='banner-bottom-grid1'><h1>""+articles[i].articleName+""</h1><p>""+articles[i].articleSideName+""</p><div class='more'><a href='/Home/Single?id=""+articles[i].id+""' class='hvr-curl-bottom-rig");
            WriteLiteral(@"ht'>Read More...</a></div></div></div>"";
			}
			$(""#IndexArticles"").append(htm);
		},
		error:function(){
			console.log(""请求失败！"");
		}
	});
	$.ajax({
		url:'/Home/showIndexModelTwo',
		type:'POST',
		dataType:'Json',
		contentType:""application/json"",
		success:function(data, textStatus){
			var articles=data.articles;
			htm=""<h3>""+articles[0].articleName+""</h3><div class='events-grid-main'><div class='overlay'>""+
				""<div class='arrow-left'></div><div class='rectangle'></div></div><div class='description'>""+
				""<h4>""+articles[0].articleSideName+""</h4><p>""+articles[0].articleContext+""</p></div>""+
				""<img src='""+articles[0].articleImgUrl.slice(22,)+""' alt='' class='img-responsive'/></div>""
			$(""#pic"").append(htm);
		},
		error:function(){
			console.log(""请求失败！"");
		}
	});
	$.ajax({
		url:'/Home/showIndexModelThree',
		type:'POST',
		dataType:'Json',
		contentType:""application/json"",
		success:function(data, textStatus){
			var articles=data.articles;
			var htm="""";
			for(var i=0;i<articles.length;i++){");
            WriteLiteral(@"
				htm+=""<div class='events-grid1-right'><a href='/Home/Single?id=""+articles[i].id+""'>""+articles[i].articleName+""</a><p>""+articles[i].articleSideName+""</p></div>"";
			}
			$(""#articlelists"").append(htm);
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
