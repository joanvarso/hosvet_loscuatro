#pragma checksum "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\SignoVitales\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2135600a4174d5ec1e5e354721614a85ebb27112"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HosVet.App.Presentacion.Pages.SignoVitales.Pages_SignoVitales_Index), @"mvc.1.0.razor-page", @"/Pages/SignoVitales/Index.cshtml")]
namespace HosVet.App.Presentacion.Pages.SignoVitales
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
#line 1 "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\_ViewImports.cshtml"
using HosVet.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2135600a4174d5ec1e5e354721614a85ebb27112", @"/Pages/SignoVitales/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7222a7bf6ee16d26b36a91ecc9d60a3a0e2e00fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SignoVitales_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 style="" text-align: center"">Administrar Signos Vitales de Mascotas</h1>
<h2>Lista de Signos Vitales</h2>
<br>
<table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">Fecha y Hora</th>
      <th scope=""col"">Signo</th>
      <th scope=""col"">Valor</th>
    </tr>
  </thead>

");
#nullable restore
#line 18 "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\SignoVitales\Index.cshtml"
   foreach (var sv in @Model.SignoVitales)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>");
#nullable restore
#line 21 "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\SignoVitales\Index.cshtml"
     Write(sv.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 22 "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\SignoVitales\Index.cshtml"
     Write(sv.TipoSigno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 23 "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\SignoVitales\Index.cshtml"
     Write(sv.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 25 "C:\MisionTic2022\Ciclo 3\DS 54\hosvet_loscuatro\HosVet.App\HosVet.App.Presentacion\Pages\SignoVitales\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HosVet.App.Presentacion.Pages.SignoVitales.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HosVet.App.Presentacion.Pages.SignoVitales.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HosVet.App.Presentacion.Pages.SignoVitales.IndexModel>)PageContext?.ViewData;
        public HosVet.App.Presentacion.Pages.SignoVitales.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
