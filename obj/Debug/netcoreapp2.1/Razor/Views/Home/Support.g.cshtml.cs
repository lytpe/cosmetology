#pragma checksum "/Users/tpe/Desktop/cosmetology/Views/Home/Support.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f48cd56fd420ff42fef6d03d42b0b821de6308c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Support), @"mvc.1.0.view", @"/Views/Home/Support.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Support.cshtml", typeof(AspNetCore.Views_Home_Support))]
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
#line 1 "/Users/tpe/Desktop/cosmetology/Views/_ViewImports.cshtml"
using Cosmetology;

#line default
#line hidden
#line 2 "/Users/tpe/Desktop/cosmetology/Views/_ViewImports.cshtml"
using Cosmetology.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f48cd56fd420ff42fef6d03d42b0b821de6308c", @"/Views/Home/Support.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecef6319a6eba9cde12fccd72687063ce2c1f341", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Support : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.11.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ad583058d524568926d68668de3cd98", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(50, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(52, 3393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "262af48801f64453928fbb1a656f9293", async() => {
                BeginContext(58, 98, true);
                WriteLiteral("\n<!-- support -->\n\t<div class=\"support\">\n\t\t\t<h3>Support Us</h3>\n\t\t\t<div class=\"support-form\">\n\t\t\t\t");
                EndContext();
                BeginContext(156, 217, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e51ff5d80d0c483d95c758239228c25c", async() => {
                    BeginContext(162, 204, true);
                    WriteLiteral("\n\t\t\t\t\t<input type=\"text\" value=\"Search support...\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Search support...\';}\" required=\"\">\n\t\t\t\t\t<input type=\"submit\" value=\"Submit\">\n\t\t\t\t");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(373, 3065, true);
                WriteLiteral(@"
			</div>
			<div class=""support-grids"">
				<div class=""col-md-8 support-grid-left"">
					<div class=""support-grid-left-grids"">
						<div class=""col-md-4 support-grid-left1"">
							<div class=""banner-bottom-grid1 support-grid-left1-grid"">
								<span class=""glyphicon glyphicon-save"" aria-hidden=""true""></span>
								<h4>Get Started</h4>
								<ul>
									<li>Patients</li>
									<li>Sports Persons</li>
									<li>Doctors</li>
								</ul>
							</div>
						</div>
						<div class=""col-md-4 support-grid-left1"">
							<div class=""banner-bottom-grid1 support-grid-left1-grid"">
								<span class=""glyphicon glyphicon-book"" aria-hidden=""true""></span>
								<h4>Documentation</h4>
								<ul>
									<li>Equipments</li>
									<li>Hospitals</li>
									<li>Certificates</li>
								</ul>
							</div>
						</div>
						<div class=""col-md-4 support-grid-left1"">
							<div class=""banner-bottom-grid1 support-grid-left1-grid"">
								<span class=""glyphicon glyphicon-retweet"" aria-hidden=""tr");
                WriteLiteral(@"ue""></span>
								<h4>Training</h4>
								<ul>
									<li>Classes</li>
									<li>Videos</li>
									<li>Practices</li>
								</ul>
							</div>
						</div>
						<div class=""clearfix""> </div>
					</div>
					<div class=""support-grid-left-grids"">
						<div class=""col-md-4 support-grid-left1"">
							<div class=""banner-bottom-grid1 support-grid-left1-grid"">
								<span class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></span>
								<h4>Answers</h4>
								<ul>
									<li>Communicate with Patients</li>
									<li>Developer Zone</li>
									<li>Knowledge Based</li>
								</ul>
							</div>
						</div>
						<div class=""col-md-4 support-grid-left1"">
							<div class=""banner-bottom-grid1 support-grid-left1-grid"">
								<span class=""glyphicon glyphicon-cloud-upload"" aria-hidden=""true""></span>
								<h4>Resources</h4>
								<ul>
									<li>Supported Platforms</li>
									<li>On Demand Status</li>
									<li>Guidance</li>
								</ul>
							</div>
						</div>
					");
                WriteLiteral(@"	<div class=""col-md-4 support-grid-left1"">
							<div class=""banner-bottom-grid1 support-grid-left1-grid"">
								<span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span>
								<h4>Support Us</h4>
								<ul>
									<li>Classes</li>
									<li>Videos</li>
									<li>Practices</li>
								</ul>
							</div>
						</div>
						<div class=""clearfix""> </div>
					</div>
				</div>
				<div class=""col-md-4 support-grid-right"">
					<div class=""banner-bottom-grid1 support-grid-right1 support-grid-left1-grid"">
						<span class=""glyphicon glyphicon-cog"" aria-hidden=""true""></span>
						<h4>Case Portal</h4>
						<p>Duis aute irure dolor in reprehenderit in voluptate velit esse 
							cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat 
							cupidatat non proident.</p>
						<div class=""more"">
							<a href=""single.html"" class=""hvr-curl-bottom-right"">Read More...</a>
						</div>
					</div>
				</div>
				<div class=""clearfix""> </div>
			</div>
	</div>
<!-- //support -->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
