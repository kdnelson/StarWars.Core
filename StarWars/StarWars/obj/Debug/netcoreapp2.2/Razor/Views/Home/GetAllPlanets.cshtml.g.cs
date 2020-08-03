#pragma checksum "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb4180764419930b4c62bf511db931205d85171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllPlanets), @"mvc.1.0.view", @"/Views/Home/GetAllPlanets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GetAllPlanets.cshtml", typeof(AspNetCore.Views_Home_GetAllPlanets))]
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
#line 1 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\_ViewImports.cshtml"
using StarWars;

#line default
#line hidden
#line 2 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\_ViewImports.cshtml"
using StarWars.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb4180764419930b4c62bf511db931205d85171", @"/Views/Home/GetAllPlanets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ecb733ab61ca2b3205788c2e61c72f92ee0e34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAllPlanets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarWars.ViewModels.Planet.SearchPlanetViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(82, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb4180764419930b4c62bf511db931205d851713439", async() => {
                BeginContext(88, 74, true);
                WriteLiteral("\r\n    <title>All Planets - Largest Diameter to Smallest Diameter</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(169, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(171, 1200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb4180764419930b4c62bf511db931205d851714695", async() => {
                BeginContext(177, 113, true);
                WriteLiteral("\r\n    <div>\r\n        <h3>All Planets - Largest Diameter to Smallest Diameter</h3>\r\n        <h5>Average Diameter: ");
                EndContext();
                BeginContext(291, 36, false);
#line 10 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                         Write(Model.DiameterAverage.ToString("N2"));

#line default
#line hidden
                EndContext();
                BeginContext(327, 366, true);
                WriteLiteral(@"</h5>
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <td>Planet Name</td>
                    <td>Population</td>
                    <td>Diameter</td>
                    <td>Terrain</td>
                    <td>Length Of Year</td>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 22 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                 foreach (var planet in Model.PlanetModelList)
                {

#line default
#line hidden
                BeginContext(776, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(823, 11, false);
#line 25 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                   Write(planet.Name);

#line default
#line hidden
                EndContext();
                BeginContext(834, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(866, 17, false);
#line 26 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                   Write(planet.Population);

#line default
#line hidden
                EndContext();
                BeginContext(883, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 27 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                     if (@planet.Diameter < 0)
                    {

#line default
#line hidden
                BeginContext(961, 42, true);
                WriteLiteral("                        <td>unknown</td>\r\n");
                EndContext();
#line 30 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                    }

#line default
#line hidden
                BeginContext(1026, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 31 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                     if (@planet.Diameter >= 0)
                    {

#line default
#line hidden
                BeginContext(1098, 28, true);
                WriteLiteral("                        <td>");
                EndContext();
                BeginContext(1127, 15, false);
#line 33 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                       Write(planet.Diameter);

#line default
#line hidden
                EndContext();
                BeginContext(1142, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
#line 34 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                    }

#line default
#line hidden
                BeginContext(1172, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(1197, 14, false);
#line 35 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                   Write(planet.Terrain);

#line default
#line hidden
                EndContext();
                BeginContext(1211, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1243, 20, false);
#line 36 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                   Write(planet.OrbitalPeriod);

#line default
#line hidden
                EndContext();
                BeginContext(1263, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 38 "C:\Users\krisd\GitHub\CoreStarWarsApp\StarWars\StarWars\Views\Home\GetAllPlanets.cshtml"
                }

#line default
#line hidden
                BeginContext(1312, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
            BeginContext(1371, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarWars.ViewModels.Planet.SearchPlanetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591