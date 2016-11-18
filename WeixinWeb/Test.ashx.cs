using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeiXinLib;
using WeiXinLib.Model;

namespace WeixinWeb
{
    /// <summary>
    /// Summary description for Test
    /// </summary>
    public class Test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //string echostr = context.Request["echostr"];
            //context.Response.ContentType = "text/plain";
            //context.Response.Write(echostr);
            //return;
            WeixinMessageHandler dd = new WeixinMessageHandler();
            ConfigModel configModel = dd.GetConfig(context);
            configModel.AccessToken = "WwSqa0gFVY1HP2-b8y-677GbVDLvU9p9dJ0nEJaalQLAkb_Y0kXlfacgPGC4H-2-B1FZhpyqzEJ86H0uuTGYfm1lhSaHeRkn98fe8JdQ7FRwzdZh1u17gfkcB9SsCnK4AHIfAAAIPQ";
            SendHandler send = new SendHandler(configModel);

            send.SendTemplate("onA99xEbEgYzggzRXIf7VbSK_z_4",
                "4bdh5zQkhuQjtohs5V2g9IZaSUyVIUt8JzQ8YXbL5o8", "", null);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    /// <summary>
    /// 模板消息实体类
    /// </summary>
    public class TemplateMessage
    {
        /// <summary>
        /// 接收方帐号（一个OpenID）
        /// </summary>
        public string touser { get; set; }

        /// <summary>
        /// 授权令牌
        /// </summary>
        [JsonIgnore]
        public string AccessToken { get; set; }

        public string template_id { get; set; }

        public string url { get; set; }

        public Dictionary<string, TemplateItem> data { get; set; }
    }

    /// <summary>
    /// 模板节点实体类
    /// </summary>
    public class TemplateItem
    {
        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }
        /// <summary>
        /// 值颜色
        /// </summary>
        public string color { get; set; }
    }
}