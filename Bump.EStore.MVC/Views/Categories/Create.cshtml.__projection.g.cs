//------------------------------------------------------------------------------
// <auto-generated>
//     �o�q�{���X�O�Ѥu�㲣�ͪ��C
//     ���涥�q����:4.0.30319.42000
//
//     ��o���ɮשҰ����ܧ�i��|�y�����~���欰�A�ӥB�p�G���s���͵{���X�A
//     �ܧ�N�|�򥢡C
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Create_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Create_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
  
    ViewBag.Title = "Create";


#line default
#line hidden

#line 2 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
  
    var options = ViewBag.FirstCategoryName;
    var options2 = ViewBag.SecondCategoryName;
    var jsOptions = Newtonsoft.Json.JsonConvert.SerializeObject(options);
    var jsOptions2 = Newtonsoft.Json.JsonConvert.SerializeObject(options2);


#line default
#line hidden

#line 3 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
using (Html.BeginForm("Index", "Categories", FormMethod.Post))
{
    

#line default
#line hidden

#line 4 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
                                                                            
    

#line default
#line hidden

#line 5 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
               
}

#line default
#line hidden
DefineSection("Scripts", () => {


#line 6 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
                 __o = Html.Raw(jsOptions);


#line default
#line hidden

#line 7 "C:\Users\leoju\AppData\Local\Temp\F5477381AF60BB3F911D3AEEA74F6FD02306\2\Bump\Bump.EStore.MVC\Views\Categories\Create.cshtml"
                  __o = Html.Raw(jsOptions2);


#line default
#line hidden
});

}
}
}