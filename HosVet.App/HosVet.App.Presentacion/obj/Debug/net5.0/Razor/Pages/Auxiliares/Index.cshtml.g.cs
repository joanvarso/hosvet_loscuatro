#pragma checksum "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a75894821190161268dbd96a2885de269b30d57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HosVet.App.Presentacion.Pages.Auxiliares.Pages_Auxiliares_Index), @"mvc.1.0.razor-page", @"/Pages/Auxiliares/Index.cshtml")]
namespace HosVet.App.Presentacion.Pages.Auxiliares
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
#line 1 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\_ViewImports.cshtml"
using HosVet.App.Presentacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
using HosVet.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a75894821190161268dbd96a2885de269b30d57", @"/Pages/Auxiliares/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7222a7bf6ee16d26b36a91ecc9d60a3a0e2e00fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Auxiliares_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a75894821190161268dbd96a2885de269b30d573516", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\">\r\n        <title>Lista de Auxiliares</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a75894821190161268dbd96a2885de269b30d574572", async() => {
                WriteLiteral(@"
        <ul class=""menu"">
            <li><a href=""/Auxiliares/Index"">Lista de auxiliares</a></li>
            <li><a href=""/Auxiliares/NuevoAuxiliar"">Nuevo auxiliar</a></li>
        </ul>
        <h1>Auxiliares de veterinaria</h1><br>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Apellidos</th>
                    <th scope=""col"">Numero de telefono</th>
                    <th scope=""col"">Genero</th>
                    <th scope=""col"">Tarjeta profesional</th>
                    <th scope=""col"">Horas Laborales</th>
                </tr>
            </thead>
");
#nullable restore
#line 28 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
             foreach (var av in @Model.auxiliarVeterinario)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
                   Write(av.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
                   Write(av.Apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
                   Write(av.NumeroTelefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
                   Write(av.Genero);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
                   Write(av.TarjetaProfesional);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
                   Write(av.HotasLaborales);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\Documents\UCaldas\Ciclo 3\Desarrollo de Software Web\Proyectos\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\Auxiliares\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HosVet.App.Presentacion.Pages.Auxiliares.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HosVet.App.Presentacion.Pages.Auxiliares.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HosVet.App.Presentacion.Pages.Auxiliares.IndexModel>)PageContext?.ViewData;
        public HosVet.App.Presentacion.Pages.Auxiliares.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
