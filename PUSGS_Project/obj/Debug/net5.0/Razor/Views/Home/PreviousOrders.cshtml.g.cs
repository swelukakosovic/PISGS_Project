#pragma checksum "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999ff16b06b06bc8bd6f23787c6d483ab7a2c05e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PreviousOrders), @"mvc.1.0.view", @"/Views/Home/PreviousOrders.cshtml")]
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
#line 1 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\_ViewImports.cshtml"
using PUSGS_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\_ViewImports.cshtml"
using PUSGS_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
using DataAcesss.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999ff16b06b06bc8bd6f23787c6d483ab7a2c05e", @"/Views/Home/PreviousOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05733ed162246433a411bb26e411818e9226933d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PreviousOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PUSGS_Project.Models.ActiveOrdersModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("currentOrderForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CurrentOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
  
    ViewData["Title"] = "Previous Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<style>\r\n    tr:hover {\r\n        background-color: #1f0160;\r\n    }\r\n</style>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n");
#nullable restore
#line 18 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
              
                if (Model == null || Model.Orders == null || Model.Orders.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Currently, you <b class=\"text-danger\">don\'t have completed</b> orders.</p>\r\n");
#nullable restore
#line 22 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label for=\"previousOrdersTable\"><b>Your completed orders (");
#nullable restore
#line 25 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                                          Write(Model.Orders.Count.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</b></label>
                    <table class=""table table-dark"" id=""previousOrdersTable"">
                        <tr>
                            <th class=""text-center"">Address</th>
                            <th class=""text-center"">Price</th>
                            <th class=""text-center"">Comment</th>
                            <th class=""text-center"">Time (minutes)</th>
                            <th class=""text-center"">Order Status</th>
                            <th class=""text-center"">Products</th>
                        </tr>
");
#nullable restore
#line 35 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                          
                            foreach (Order order in Model.Orders)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("id", " id=\"", 1525, "\"", 1544, 1);
#nullable restore
#line 38 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
WriteAttributeValue("", 1530, order.OrderId, 1530, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1545, "\"", 1585, 3);
            WriteAttributeValue("", 1555, "CurrentOrder(\'", 1555, 14, true);
#nullable restore
#line 38 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
WriteAttributeValue("", 1569, order.OrderId, 1569, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1583, "\')", 1583, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 39 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                       Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 40 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                       Write(order.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 41 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                       Write(order.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
#nullable restore
#line 42 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                       Write(order.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\"><b class=\"text-success\">Delivered</b>\r\n                                    </td>\r\n\r\n\r\n                                    <td class=\"text-left\">\r\n");
#nullable restore
#line 48 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                          
                                            if (Model.Products != null && Model.Products.Count > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <ul>\r\n");
#nullable restore
#line 52 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                      
                                                        foreach (var productData in Model.Products[order.OrderId])
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <li>");
#nullable restore
#line 55 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                           Write(productData.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 55 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                                                   Write(productData.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 56 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                                        }
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 59 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-danger\">No products available.</p>\r\n");
#nullable restore
#line 63 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                    <script type=""text/javascript"">
                        function CurrentOrder(orderId) {
                            document.getElementById(""orderId"").value = orderId;
                            document.getElementById(""currentOrderForm"").submit();
                        }
                    </script>
");
#nullable restore
#line 77 "C:\Users\Luka Kosovic\Desktop\PUSGS_Project\PUSGS_Project\Views\Home\PreviousOrders.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999ff16b06b06bc8bd6f23787c6d483ab7a2c05e13430", async() => {
                WriteLiteral("\r\n    <input type=\"text\" id=\"orderId\" name=\"orderId\"");
                BeginWriteAttribute("value", " value=\"", 3954, "\"", 3962, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PUSGS_Project.Models.ActiveOrdersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
