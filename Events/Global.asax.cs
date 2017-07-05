using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Events
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["TotalApplication"] = 0;
            Application["TotalUserSession"] = 0;
            Application["TotalApplication"] = (int)Application["TotalApplication"] + 1;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["TotalUserSession"] = (int)Application["TotalUserSession"] + 1;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["TotalUserSession"] = (int)Application["TotalUserSession"] - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}