#pragma checksum "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c158d1c45404997fbc8eee955f3a7b62b86fd85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\_ViewImports.cshtml"
using CalendarEGUIc1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\_ViewImports.cshtml"
using CalendarEGUIc1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c158d1c45404997fbc8eee955f3a7b62b86fd85", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87cb9f2cb88ed79a333f6d4d17a90c4edac430cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c158d1c45404997fbc8eee955f3a7b62b86fd853214", async() => {
                WriteLiteral(@"
    <style>
        * {
            box-sizing: border-box;
        }

        ul {
            list-style-type: none;
        }

        body {
            font-family: Verdana, sans-serif;
        }

        .month {
            padding: 30px 10px;
            width: 100%;
            background: orange;
            text-align: center;
        }

            .month ul {
                margin: 0;
                padding: 0;
            }

                .month ul li {
                    color: white;
                    font-size: 40px;
                    text-transform: uppercase;
                    letter-spacing: 3px;
                }

            .month .prev {
                float: left;
                padding-top: 10px;
            }

            .month .next {
                float: right;
                padding-top: 10px;
            }

        .weekdays {
            margin: 0;
            padding: 20px 0;
            background-color: darkoran");
                WriteLiteral(@"ge;
        }

            .weekdays li {
                display: inline-block;
                width: 13.6%;
                color: white;
                font-size: 30px;
                text-align: center;
            }

        .days {
            padding: 20px 0;
            background: orange;
            margin: 0;
        }

            .days li {
                list-style-type: none;
                display: inline-block;
                width: 13.6%;
                text-align: center;
                margin-bottom: 5px;
                font-size: 16px;
                color: #777;
            }

                .days li .active {
                    padding: 8px;
                    background: darkorange;
                    color: white !important
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c158d1c45404997fbc8eee955f3a7b62b86fd856074", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"month\">\r\n        <ul>\r\n            <li class=\"prev\"><a");
                BeginWriteAttribute("href", " href=\"", 3234, "\"", 3253, 1);
#nullable restore
#line 145 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
WriteAttributeValue("", 3241, PrevMonth(), 3241, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&#10094;</a></li>\r\n            <li class=\"next\"><a");
                BeginWriteAttribute("href", " href=\"", 3305, "\"", 3324, 1);
#nullable restore
#line 146 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
WriteAttributeValue("", 3312, NextMonth(), 3312, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&#10095;</a></li>\r\n            <li>\r\n                ");
#nullable restore
#line 148 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
           Write(MonthAndYear());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </li>
        </ul>
    </div>

    <ul class=""weekdays"">
        <li>Mo</li>
        <li>Tu</li>
        <li>We</li>
        <li>Th</li>
        <li>Fr</li>
        <li>Sa</li>
        <li>Su</li>
    </ul>

    <ul class=""days"">

");
#nullable restore
#line 165 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
         for (int j = 0; j < (int)ViewData["Shift"] - 1; j++)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li></li>\r\n");
#nullable restore
#line 168 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 170 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
         for (int i = 1; i < (int)ViewData["Days"] + 1; i++)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 173 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
             if (i == (int)ViewData["CurrDay"] && DateTime.Now.Month == (int)ViewData["Month"] && DateTime.Now.Year == (int)ViewData["Year"])
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li><span class=\"active\"><a");
                BeginWriteAttribute("href", " href=\"", 4042, "\"", 4060, 1);
#nullable restore
#line 175 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
WriteAttributeValue("", 4049, GoToDay(i), 4049, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 175 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
                                                          Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></span></li>\r\n");
#nullable restore
#line 176 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li><a");
                BeginWriteAttribute("href", " href=\"", 4152, "\"", 4170, 1);
#nullable restore
#line 179 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
WriteAttributeValue("", 4159, GoToDay(i), 4159, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 179 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
                                     Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 180 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </ul>\r\n\r\n");
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
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\HP\Desktop\EGUI\CalendarEGUIc1\Views\Home\Index.cshtml"
 
    public string NextMonth()
    {
        int year = (int)ViewData["Year"];
        int month = (int)ViewData["Month"];

        month++;

        if(month >= 12)
        {
            year++;
            month = 1;
        }

        var link = "Home?year=" + year + "&month=" + month;
        return link;
    }

    public string PrevMonth()
    {
        int year = (int)ViewData["Year"];
        int month = (int)ViewData["Month"];

        month--;

        if (month <= 0)
        {
            year--;
            month = 12;
        }

        var link = "Home?year=" + year + "&month=" + month;
        return link;
    }

    public string MonthAndYear()
    {
        string[] names = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        var m = names[(int)ViewData["Month"] - 1];
        var y = ViewData["Year"];
        var t = m + " - " + y;

        return t;
    }

    public string GoToDay(int i)
    {
        var day = i;
        var month = ViewData["Month"];
        var year = ViewData["Year"];

        var link = "events?date=" + day + "/" + month + "/" + year;
        return link;
    }


#line default
#line hidden
#nullable disable
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