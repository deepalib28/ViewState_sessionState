using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_sessionState
{
    /// <summary>
    /// 1.Viewstate value is only accessible to same page.
    /// 2.Session variable can be access across pages.
    /// 
    /// 3.Viewstate information  is stored in hidden field in client side.
    /// 4.VIewstate is base64 encoded so not good for critical information.
    /// 
    /// 
    /// 5.Session Data is stored on the server and keys  are stored in cookies files.
    /// 6.If cookie is disabled then session id key passed via query string.
    /// 7.As data stored on server critical info can be stored.
    /// 8.viewstate is a client side state management,session is server side
    /// 
    ///                 ViewState                 Session
    /// Data storage | Browser hidden feilds  |   on Server
    /// Accessible   | on the same page       |   across pages
    /// uses cookies |     NA                 |   yes if cookies disabled will use URL Querystring
    /// 
    /// 
    /// 
    /// </summary>

    public partial class OtherPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(ViewState["Counter"]);
            Response.Write(Session["Counter"]);
        }
    }
}