#pragma checksum "C:\Users\Lenovo\Desktop\dotnet scratch\EmailSender\Views\MailSender\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad3ec51635bb242dab9b4bcf58f609cc76f7994a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MailSender_Index), @"mvc.1.0.view", @"/Views/MailSender/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3ec51635bb242dab9b4bcf58f609cc76f7994a", @"/Views/MailSender/Index.cshtml")]
    public class Views_MailSender_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3ec51635bb242dab9b4bcf58f609cc76f7994a2744", async() => {
                WriteLiteral(@"
  <title>Contact V2</title>
  <meta charset=""UTF-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<!--===============================================================================================-->
  <link rel=""icon"" type=""image/png"" href=""images/icons/favicon.ico""/>
<!--===============================================================================================-->
  <link rel=""stylesheet"" type=""text/css"" href=""vendor/bootstrap/css/bootstrap.min.css"">
<!--===============================================================================================-->
  <link rel=""stylesheet"" type=""text/css"" href=""fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
<!--===============================================================================================-->
  <link rel=""stylesheet"" type=""text/css"" href=""vendor/animate/animate.css"">
<!--===============================================================================================-->
  <link rel=""stylesheet"" type=""text/cs");
                WriteLiteral(@"s"" href=""vendor/css-hamburgers/hamburgers.min.css"">
<!--===============================================================================================-->
  <link rel=""stylesheet"" type=""text/css"" href=""vendor/select2/select2.min.css"">
<!--===============================================================================================-->
  <link rel=""stylesheet"" type=""text/css"" href=""css/util.css"">
  <link rel=""stylesheet"" type=""text/css"" href=""css/main.css"">
<!--===============================================================================================-->
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3ec51635bb242dab9b4bcf58f609cc76f7994a5393", async() => {
                WriteLiteral(@"
  <div class=""bg-contact2"" style=""background-image: url('images/bg-01.jpg');"">
    <div class=""container-contact2"">
      <div class=""wrap-contact2"">
        <span class=""contact2-form-title"">
          Contact Us
        </span>
        <div class=""wrap-input2 validate-input"" data-validate=""Name is required"">
          <input class=""input2"" type=""text"" id=""name"">
          <span class=""focus-input2"" data-placeholder=""NAME""></span>
        </div>
        <div class=""wrap-input2 validate-input"" data-validate = ""Valid email is required: ex@abc.xyz"">
          <input class=""input2"" type=""text"" id=""email"">
          <span class=""focus-input2"" data-placeholder=""EMAIL""></span>
        </div>
        <div class=""wrap-input2 validate-input"" data-validate = ""Message is required"">
          <textarea class=""input2"" id=""message""></textarea>
          <span class=""focus-input2"" data-placeholder=""MESSAGE""></span>
        </div>
        <div class=""container-contact2-form-btn"">
          <div class=""wr");
                WriteLiteral(@"ap-contact2-form-btn"">
            <div class=""contact2-form-bgbtn""></div>
            <button class=""contact2-form-btn"" onclick=""SendEmail()"">
              Send Your Message
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
<!--===============================================================================================-->
  <script src=""vendor/jquery/jquery-3.2.1.min.js""></script>
<!--===============================================================================================-->
  <script src=""vendor/bootstrap/js/popper.js""></script>
  <script src=""vendor/bootstrap/js/bootstrap.min.js""></script>
<!--===============================================================================================-->
  <script src=""vendor/select2/select2.min.js""></script>
<!--===============================================================================================-->
  <script src=""js/main.js""></script>
  <script>
    function SendEmail(){
      $.ajax(
    ");
                WriteLiteral("  {\r\n        type: \"POST\",\r\n        url: \'");
#nullable restore
#line 68 "C:\Users\Lenovo\Desktop\dotnet scratch\EmailSender\Views\MailSender\Index.cshtml"
         Write(Url.Action("SendEmail", "MailSender"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
        data: {
          Name: $(""#name"").val(),
          Email: $(""#email"").val(),
          Message: $(""#message"").val()
        },
        error: function (result) {
          console.log(result);
        },
        success: function (result) {
          alert(result);
          $(""#name"").val("""");
          $(""#email"").val("""");
          $(""#message"").val("""");
        }
      });
    }
  </script>
");
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
