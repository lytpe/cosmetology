#pragma checksum "d:\Cosmetology\Views\Home\Mail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c6345a64765626642d57faf7f6d9d1ac866a9fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Mail), @"mvc.1.0.view", @"/Views/Home/Mail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Mail.cshtml", typeof(AspNetCore.Views_Home_Mail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6345a64765626642d57faf7f6d9d1ac866a9fd", @"/Views/Home/Mail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "d:\Cosmetology\Views\Home\Mail.cshtml"
  
	ViewData["Title"]="联系";

#line default
#line hidden
            BeginContext(30, 456, true);
            WriteLiteral(@"<div class=""container"">
	<div class=""row"">
			<div class=""col-md-4 col-sm-12 col-lg-4 contact-left"">
				<h1>地址</h1>
				<p>中国 江苏省 常熟市
					<span>215500 Rescue,US</span></p>
				<ul>
					<li>固定电话 :0512-52567270</li>
					<li>手机 :18994407668</li>
					<li>手机 :15962317511</li>
					<li><a href=""mailto:2386087177@qq.com"">contact 2386087177@qq.com</a></li>
				</ul>
			</div>
			<div class=""col-md-8 col-sm-12 col-lg-8 contact-left"">
				<h2>联系方式</h2>
				");
            EndContext();
            BeginContext(486, 462, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bda624ff77e451daf6a5ec2d2d704b5", async() => {
                BeginContext(528, 413, true);
                WriteLiteral(@"
					<input id=""name"" type=""text""  name=""Name""  placeholder=""姓名"" required>
					<input id=""email"" type=""email""  name=""Email""  placeholder=""邮箱"" required>
					<input id=""phone"" type=""text""   name=""Phone""  placeholder=""电话"" required>
					<textarea id=""infos"" type=""text""  name=""Infos""  placeholder=""您的信息。。。"" required></textarea>
					<input type=""submit"" class=""btn btn-primary"" value=""提交"" name=""提交""></Button>
				");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(948, 1613, true);
            WriteLiteral(@"
			</div>
	</div>
	<br/>
	<div class=""row"">
         <div id=""map"" class=""col-md-12 col-sm-12 col-lg-12"" style=""height:600px;""></div>
	</div>
	<br/>
</div>
<script type=""text/javascript"" src=""https://api.map.baidu.com/api?v=2.0&ak=LEC1NI7PdI4wk7bHSVvnZ2y8qSdzuhGC&s=1""></script>
<script type=""text/javascript"">
var sContent =
	""<h4>苏州瑞兰雅</h4>"" + 
	""<img style='float:right;margin:4px' id='imgDemo' src='../contents/logo.jpg' width='139' height='104' title='天安门'/>"" + 
	""<p>地址：常熟市黄河路777号佳和广场二幢414</p>"" + 
	""</div>"";
	var infoWindow = new BMap.InfoWindow(sContent);  // 创建信息窗口对象
    var map=new BMap.Map(""map"");
	map.enableScrollWheelZoom(true);
    map.addControl(new BMap.NavigationControl());
	var myGeo = new BMap.Geocoder();      
	// 将地址解析结果显示在地图上，并调整地图视野    
	myGeo.getPoint(""常熟市黄河路777号佳和广场二幢414"", function(point){      
		if (point) {      
			map.centerAndZoom(point, 16);      
			var marker=new BMap.Marker(point);
			map.addOverlay(marker);
		marker.addEventListener(""click"", function(){          
			this.openInf");
            WriteLiteral(@"oWindow(infoWindow);
			//图片加载完毕重绘infowindow
			document.getElementById('imgDemo').onload = function (){
				infoWindow.redraw();   //防止在网速较慢，图片未加载时，生成的信息框高度比图片的总高度小，导致图片部分被隐藏
			}
		});

		}      
	}, 
	""苏州市"");
     var form=document.getElementById(""myForm"");
	 var formData=new FormData(form);
	 formData.get(""Name"");
	 formData.get(""Phone"");
	 formData.get(""Email"");
	 formData.get(""Infos"");
	 $("".btn btn-primary"").click(function(){
				$.ajax({
					url:'/Home/Mail',
					type:'POST',
					data:formData,
					contentType:false,
					processData:false,
				});
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
