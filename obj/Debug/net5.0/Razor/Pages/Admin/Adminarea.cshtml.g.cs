#pragma checksum "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a0b619befe930172491758d7a9b449fdb7e4df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PROJEKT.Pages.Admin.Pages_Admin_Adminarea), @"mvc.1.0.razor-page", @"/Pages/Admin/Adminarea.cshtml")]
namespace PROJEKT.Pages.Admin
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
#line 1 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\_ViewImports.cshtml"
using PROJEKT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a0b619befe930172491758d7a9b449fdb7e4df7", @"/Pages/Admin/Adminarea.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c9c884237ff4643b3a3541a385e930dd7254d38", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Adminarea : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml"
  
    ViewData["Title"] = "adminarea";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Admin Page</h1>\r\n<h2>Welcome ");
#nullable restore
#line 8 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml"
       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml"
     foreach (var c in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml"
       Write(c.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml"
                Write(c.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\jacko\Desktop\PROJKET_DOTNET\PROJEKT\Pages\Admin\Adminarea.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROJEKT.Pages.Admin.AdminareaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROJEKT.Pages.Admin.AdminareaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PROJEKT.Pages.Admin.AdminareaModel>)PageContext?.ViewData;
        public PROJEKT.Pages.Admin.AdminareaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
