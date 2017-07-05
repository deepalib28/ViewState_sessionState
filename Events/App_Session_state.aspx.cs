using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Events
{
    public partial class App_Session_state : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("No. of Application " + Application["TotalApplication"]);
            Response.Write("<br>");
            Response.Write("No. of Active user " + Application["TotalUserSession"]);
        }
    }
}