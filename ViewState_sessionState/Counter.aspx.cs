using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewState_sessionState
{
    public partial class Counter1 : System.Web.UI.Page
    {
        private int _Counter;
        /*
         * Viewstate
         */

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    _Counter = Convert.ToInt32(ViewState["Counter"]);
        //}
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    _Counter++;
        //    ViewState["Counter"] = _Counter;
        //    Response.Write(_Counter);
        //}
        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("OtherPage.aspx");
        ////server.Transfer("aspx page");
        //}

        /*
         * SessionState
         */

        protected void Page_Load(object sender, EventArgs e)
        {
            _Counter = Convert.ToInt32(Session["Counter"]);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            _Counter++;
            Session["Counter"] = _Counter;
            Response.Write(_Counter);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("OtherPage.aspx");
        }

    }
}