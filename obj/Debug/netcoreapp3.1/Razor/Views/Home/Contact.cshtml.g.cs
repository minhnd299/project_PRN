#pragma checksum "C:\Users\admin\Desktop\Web_MVC\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\Home\Contact.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a3195b0dd3a7505428211f2a4b75b103c375fa5efdc38b02170ae19456e5f47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\admin\Desktop\Web_MVC\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\_ViewImports.cshtml"
using QL_BanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\Web_MVC\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\_ViewImports.cshtml"
using QL_BanHang.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\Web_MVC\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8a3195b0dd3a7505428211f2a4b75b103c375fa5efdc38b02170ae19456e5f47", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"70429a805340e16be9d0efc642e7da2aa209de33e1b6777b716592f7bef1a2be", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3195b0dd3a7505428211f2a4b75b103c375fa5efdc38b02170ae19456e5f473954", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Contact</title>\r\n\r\n    <style>\r\n        ");
                WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Montserrat+Alternates:wght@400;700&family=Open+Sans:ital,wght@0,400;1,500&family=Playfair+Display:wght@500;600&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=Source+Sans+Pro:ital,wght@0,200;0,300;0,400;0,600;0,700;0,900;1,200;1,300;1,400;1,600;1,700;1,900&display=swap');

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
          
            width: 100%;
            height: 100vh;
            display: grid;
            align-items: center;
            background-color: lightgray;
            font-family: 'Poppins', sans-serif;
        }

        .contact {
            width: 80%;
            height: 80%;
            margin: auto;
            display: flex;
            border-radius: 10px;
            background: #fff;
            box-shadow: 0px 0px 10px 0px #666;
   ");
                WriteLiteral(@"         text-align: center;
        }

        .contact-map {
            width: 100%;
            height: auto;
            flex: 50%;
        }

            .contact-map iframe {
                border: 1px groove;
                width: 95%;
                height: 95%;
                margin: 10px 0;
            }

        .contact-form {
            width: 100%;
            height: auto;
            flex: 50%;
            padding: 30px;
            text-align: center;
        }

        .contact-form-txt::placeholder {
            color: #aaa;
        }

        .contact-form h3 {
            margin-bottom: 10px;
        }

        .contact-form-txt {
            width: 100%;
            height: 40px;
            color: #000;
            border: 1px solid #bcbcbc;
            border-radius: 5px;
            outline: none;
            margin-bottom: 20px;
            padding: 15px;
        }

        .contact-form-textarea {
            width: 100%;
          ");
                WriteLiteral(@"  height: 130px;         
            border: 1px solid #bcbcbc;
            border-radius: 5px;
            outline: none;
            margin-bottom: 20px;
            padding: 15px;
            font-family: 'Poppins', sans-serif;
        }

            .contact-form-textarea::placeholder {
                color: #aaa;
            }

        .contact-form-btn {
            width: 100%;
            border: none;
            outline: none;
            border-radius: 5px;
            background: gray;
            background-color: #0ec121;
            text-transform: uppercase;
            padding: 10px 10px;
            cursor: pointer;
            font-size: 18px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3195b0dd3a7505428211f2a4b75b103c375fa5efdc38b02170ae19456e5f478058", async() => {
                WriteLiteral(@"
    <div class=""contact mx-auto h-100"">
        <div class=""contact-map"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d15675.700478513949!2d106.6771076!3d10.8170424!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xc9ef195798144b1f!2zVHLGsOG7nW5nIMSQ4bqhaSBo4buNYyBN4bufIFRQLkhDTSAtIEPGoSBz4bufIDM!5e0!3m2!1svi!2s!4v1665855058239!5m2!1svi!2s"" width=""100"" height=""100"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 3460, "\"", 3478, 0);
                EndWriteAttribute();
                WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n        </div>\r\n        <div class=\"contact-form\">\r\n            <h2>Liên hệ</h2>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a3195b0dd3a7505428211f2a4b75b103c375fa5efdc38b02170ae19456e5f479116", async() => {
                    WriteLiteral(@"
                <input type=""text"" placeholder=""Name"" class=""contact-form-txt"" />
                <input type=""text"" placeholder=""Email"" class=""contact-form-txt"" />
                <textarea placeholder=""Message"" class=""contact-form-textarea""></textarea>
                <input type=""submit"" name=""Gửi""value=""Gửi đi"" class=""contact-form-btn"" style=""background-color: lightcoral"" />

            ");
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
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591