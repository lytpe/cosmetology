#pragma checksum "d:\Cosmetology\Views\Home\Mail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1839ceec84776bb0db3e8b55c248440b36698706"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1839ceec84776bb0db3e8b55c248440b36698706", @"/Views/Home/Mail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Mail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mails"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(486, 408, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03c87aa34be846be874b8647ddd23608", async() => {
                BeginContext(505, 382, true);
                WriteLiteral(@"
					<input id=""name"" type=""text""  name=""Name""  placeholder=""姓名"" required>
					<input id=""email"" type=""email""  name=""Email""  placeholder=""邮箱"" required>
					<input id=""phone"" type=""text""   name=""Phone""  placeholder=""电话"" required>
					<textarea id=""infos"" type=""text""  name=""Infos""  placeholder=""您的信息。。。"" required></textarea>
					<input type=""submit"" value=""提交"" id=""submit"">
				");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(894, 881, true);
            WriteLiteral(@"
			</div>
	</div>
	<br/>
	<div class=""row"">
		 <iframe  class=""col-sm-12 col-md-12 col-lg-12""  height=""600"" frameborder=""0"" scrolling=""no""  src=""https://api.map.baidu.com/geocoder?address=常熟市黄河路777号佳和广场二幢414&coord_type=gcj02&output=html&src=webapp.baidu.openAPIdemo""></iframe> 
	</div>
	<br/>
</div>
<script type=""text/javascript"">
    var name=$(""#name"").value;
	var email=$(""#email"").value;
    var phone=$(""#phone"").value;
	var infos=$(""#infos"").value;
	$(""#submit"").click(function(){
		if(name!=null&&email!=null&&phone!=null&&infos!=null){
			$.ajax({
				type:'POST',
				url:'/Home/Mail',
				contentType: ""application/json"",  
				data:$(""#mails"").serialize(),
				dataType: ""json"", //json类型
				success:function(res){
					//var result = JSON.stringify(res); 
					alert(""提交成功"");
				},
				error:function(res){
					alert(""提交失败!请耐心重新填写"");
				}
			});
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
