#pragma checksum "D:\CF\TFS\OctoGen\Dev\aspnet-core\src\CF.Octogo.Web.Public\Views\Layout\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1801bf004a8898ae1a81463894ef82670d668aee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout__Footer), @"mvc.1.0.view", @"/Views/Layout/_Footer.cshtml")]
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
#line 1 "D:\CF\TFS\OctoGen\Dev\aspnet-core\src\CF.Octogo.Web.Public\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\CF\TFS\OctoGen\Dev\aspnet-core\src\CF.Octogo.Web.Public\Views\Layout\_Footer.cshtml"
using Abp.Timing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1801bf004a8898ae1a81463894ef82670d668aee", @"/Views/Layout/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9edd74525b22634582190c23243be6b5738718", @"/Views/_ViewImports.cshtml")]
    public class Views_Layout__Footer : CF.Octogo.Web.Public.Views.OctogoRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- BEGIN FOOTER -->\n<div class=\"footer\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <!-- BEGIN COPYRIGHT -->\n            <div class=\"col-md-6 col-sm-6 padding-top-10\">\n                ");
#nullable restore
#line 8 "D:\CF\TFS\OctoGen\Dev\aspnet-core\src\CF.Octogo.Web.Public\Views\Layout\_Footer.cshtml"
           Write(Clock.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" © Octogo. ALL Rights Reserved. <a href=""javascript:;"">Privacy Policy</a> | <a href=""javascript:;"">Terms of Service</a>
            </div>
            <!-- END COPYRIGHT -->
            <!-- BEGIN PAYMENTS -->
            <div class=""col-md-6 col-sm-6"">
                <ul class=""social-footer list-unstyled list-inline pull-right"">
                    <li><a href=""javascript:;""><i class=""fa fa-facebook"" aria-label=""Facebook""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-google-plus"" aria-label=""Google plus""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-dribbble"" aria-label=""Dribble""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-linkedin"" aria-label=""Linkedin""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-twitter"" aria-label=""Twitter""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-skype"" aria-label=""Skype""></i></a></li>
                    <li><a href=""javasc");
            WriteLiteral(@"ript:;""><i class=""fa fa-github"" aria-label=""Github""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-youtube"" aria-label=""Youtube""></i></a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-dropbox"" aria-label=""Dropbox""></i></a></li>
                </ul>
            </div>
            <!-- END PAYMENTS -->
        </div>
    </div>
</div>
<!-- END FOOTER -->");
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
