using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WeixinWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            WeiXinLib.Model.ConfigModel config = new WeiXinLib.Model.ConfigModel();
            config.AppId = "wx8b711cc5ca037d9e";
            config.AppSecret = "7970e8bcff9c65c81ad33a5e35fc69d0";
            config.Token = "JlzntcTokenTest";
            WeiXinLib.ConfigManager.SetConfig(config);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

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

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}