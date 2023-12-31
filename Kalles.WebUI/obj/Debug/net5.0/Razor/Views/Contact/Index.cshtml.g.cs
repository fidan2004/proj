#pragma checksum "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5daad48e0549dd6dbcfbd25652f8c2ad70be0882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 3 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Domain.Models.FormModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\_ViewImports.cshtml"
using Kalles.Application.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5daad48e0549dd6dbcfbd25652f8c2ad70be0882", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09da619775bce39acaf82e14e290047d9a5d42f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Hp\Desktop\Kalles\Kalles.WebUI\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main>


    <div class=""collection_top_background"">
        <div class=""backgroundShadow"">
            <h1>CONTACT</h1>
        </div>
    </div>

    <section class=""contact_map_container"">
        <div class=""contact_map"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d97252.92244912653!2d49.8761728!3d40.3832832!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1saz!2saz!4v1687444006269!5m2!1saz!2saz"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 538, "\"", 556, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
        </div>
    </section>
    <section class=""section"">
        <div class=""container"">
            <div class=""contact_container"">
                <div class=""contact_side"">
                    <h3 class=""page_header"">DROP US A LINE</h3>
                    <div class=""inp_card"">
                        <label for=""name"">Your Name (required)</label>
                        <input type=""text"" id=""name"">
                    </div>
                    <div class=""inp_card"">
                        <label for=""email"">Your Email (required)</label>
                        <input type=""email"" id=""email"">
                    </div>
                    <div class=""inp_card"">
                        <label for=""phone"">Your Phone Number</label>
                        <input type=""text"" id=""phone"">
                    </div>
                    <div class=""inp_card"">
                        <label for=""message"">Your Message</");
            WriteLiteral(@"label>
                        <textarea id=""message"" cols=""30"" rows=""10""></textarea>
                    </div>
                    <div class=""inp_card"">
                        <button onclick=""sendContact()"">Send</button>
                    </div>
                </div>
                <div class=""contact_side"">
                    <h3 class=""page_header"">CONTACT INFORMATION</h3>
                    <p>We love to hear from you on our customer service, merchandise, website or any topics you want to share with us. Your comments and suggestions will be appreciated. Please complete the form below.</p>
                    <p>
                        <svg fill=""#000000"" width=""14px"" height=""14px"" viewBox=""0 0 32 32"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" stroke=""#000000"" stroke-width=""0.00032""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M31.772 16.043l-15.012-15.724c-0.");
            WriteLiteral(@"189-0.197-0.449-0.307-0.721-0.307s-0.533 0.111-0.722 0.307l-15.089 15.724c-0.383 0.398-0.369 1.031 0.029 1.414 0.399 0.382 1.031 0.371 1.414-0.029l1.344-1.401v14.963c0 0.552 0.448 1 1 1h6.986c0.551 0 0.998-0.445 1-0.997l0.031-9.989h7.969v9.986c0 0.552 0.448 1 1 1h6.983c0.552 0 1-0.448 1-1v-14.968l1.343 1.407c0.197 0.204 0.459 0.308 0.722 0.308 0.249 0 0.499-0.092 0.692-0.279 0.398-0.382 0.411-1.015 0.029-1.413zM26.985 14.213v15.776h-4.983v-9.986c0-0.552-0.448-1-1-1h-9.965c-0.551 0-0.998 0.445-1 0.997l-0.031 9.989h-4.989v-15.777c0-0.082-0.013-0.162-0.032-0.239l11.055-11.52 10.982 11.507c-0.021 0.081-0.036 0.165-0.036 0.252z""></path> </g></svg>
                        184 Main Rd E, St Albans Victoria 3021, Australia
                    </p>
                    <p>
                        <svg width=""16px"" height=""16px"" viewBox=""0 0 48 48"" id=""b"" xmlns=""http://www.w3.org/2000/svg"" fill=""#000000"" stroke=""#000000"" stroke-width=""1.584"">
                            <g id=""SVGRepo_bgCarrier"" stroke-width=""0""></");
            WriteLiteral(@"g>
                            <g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g>
                            <g id=""SVGRepo_iconCarrier"">
                                <defs>
                                    <style>
                                        .c {
                                            fill: none;
                                            stroke: #000000;
                                            stroke-linecap: round;
                                            stroke-linejoin: round;
                                        }</style>
                                </defs><path class=""c"" d=""m19.308,12.467c-.4234-1.4115-.7215-2.8773-.8813-4.3843-.1571-1.4812-1.449-2.5826-2.9385-2.5826h-6.9092c-1.7767,0-3.1454,1.5345-2.989,3.3043,1.5754,17.8285,15.7771,32.0302,33.6056,33.6056,1.7698.1564,3.3043-1.2073,3.3043-2.9839v-6.1595c0-2.2488-1.1015-3.5362-2.5826-3.6932-1.507-.1598-2.9728-.4579-4.3843-.8813-1.7266-.5179-3.5957-.0304-4.8704,1.2442l-2.95");
            WriteLiteral(@"66,2.9566c-5.326-2.8825-9.7164-7.2729-12.5989-12.5989l2.9566-2.9567c1.2746-1.2746,1.7621-3.1438,1.2442-4.8703Z""></path>
                            </g>
                        </svg>
                        1800-123-222 / 1900-1570-230
                    </p>
                    <p>
                        <svg fill=""#000000"" width=""14px"" height=""14px"" viewBox=""0 0 1024 1024"" xmlns=""http://www.w3.org/2000/svg"" stroke=""#000000"" stroke-width=""0.01024""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""><path d=""M1023.46 232a31.629 31.629 0 0 0-2.48-18.271C1012.917 178.288 987.3 160 944.005 160h-832c-38.08 0-79.105 14-99.28 41.472-1.745 1.328-3.409 2.832-4.912 4.576-6.449 7.44-8.705 17.009-7.264 26.033-.288 2.592-.544 5.2-.544 7.92v512c0 53.024 58.992 112 112 112h832c53.024 0 80-58.976 80-112v-512c0-2.832-.368-5.313-.544-8.001zm-911.459-8l832.001-.001h.432L512.002 568.655 81.314 225.407C91.106 223.599 ");
            WriteLiteral(@"103.154 224 112 224zm832.001 575.999H112.003c-17.648 0-48-30.336-48-48V293.551l427.04 341.648c6.016 5.2 13.487 7.792 20.959 7.792a32.046 32.046 0 0 0 20.976-7.792l427.024-341.632v458.432c0 17.664 1.664 48-16 48z""></path></g></svg>
                        contact@company.com
                    </p>
                    <p>
                        <svg width=""16px"" height=""16px"" viewBox=""0 0 24 24"" fill=""none"" xmlns=""http://www.w3.org/2000/svg""><g id=""SVGRepo_bgCarrier"" stroke-width=""0""></g><g id=""SVGRepo_tracerCarrier"" stroke-linecap=""round"" stroke-linejoin=""round""></g><g id=""SVGRepo_iconCarrier""> <path d=""M12 21C10.22 21 8.47991 20.4722 6.99987 19.4832C5.51983 18.4943 4.36628 17.0887 3.68509 15.4442C3.0039 13.7996 2.82567 11.99 3.17294 10.2442C3.5202 8.49836 4.37737 6.89472 5.63604 5.63604C6.89472 4.37737 8.49836 3.5202 10.2442 3.17294C11.99 2.82567 13.7996 3.0039 15.4442 3.68509C17.0887 4.36628 18.4943 5.51983 19.4832 6.99987C20.4722 8.47991 21 10.22 21 12C21 14.387 20.0518 16.6761 18.364 18.364C16.6761 ");
            WriteLiteral(@"20.0518 14.387 21 12 21ZM12 4.5C10.5166 4.5 9.0666 4.93987 7.83323 5.76398C6.59986 6.58809 5.63856 7.75943 5.07091 9.12988C4.50325 10.5003 4.35473 12.0083 4.64411 13.4632C4.9335 14.918 5.64781 16.2544 6.6967 17.3033C7.7456 18.3522 9.08197 19.0665 10.5368 19.3559C11.9917 19.6453 13.4997 19.4968 14.8701 18.9291C16.2406 18.3614 17.4119 17.4001 18.236 16.1668C19.0601 14.9334 19.5 13.4834 19.5 12C19.5 10.0109 18.7098 8.10323 17.3033 6.6967C15.8968 5.29018 13.9891 4.5 12 4.5Z"" fill=""#878787""></path> <path d=""M15 12.75H12C11.8019 12.7474 11.6126 12.6676 11.4725 12.5275C11.3324 12.3874 11.2526 12.1981 11.25 12V7C11.25 6.80109 11.329 6.61032 11.4697 6.46967C11.6103 6.32902 11.8011 6.25 12 6.25C12.1989 6.25 12.3897 6.32902 12.5303 6.46967C12.671 6.61032 12.75 6.80109 12.75 7V11.25H15C15.1989 11.25 15.3897 11.329 15.5303 11.4697C15.671 11.6103 15.75 11.8011 15.75 12C15.75 12.1989 15.671 12.3897 15.5303 12.5303C15.3897 12.671 15.1989 12.75 15 12.75Z"" fill=""#878787""></path> </g></svg>
                        Everyday 9:0");
            WriteLiteral(@"0-17:00
                    </p>
                </div>
            </div>
        </div>
    </section>

</main>

<script>
    const name = document.getElementById('name')
    const email = document.getElementById('email')
    const phone = document.getElementById('phone')
    const message = document.getElementById('message')
function sendContact() {

    data = {
        name : name.value,
        email : email.value,
        phone : phone.value,
        message : message.value
    }
      emailjs.send('service_5p4gquf', 'template_o88mn5t', data)
        .then(function (response) {
            console.log('SUCCESS!', response.status, response.text);
        }, function (error) {
            console.log('FAILED...', error);
        });
}
</script>
");
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
