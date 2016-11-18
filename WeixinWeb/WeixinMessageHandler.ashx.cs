using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeiXinLib;
using WeiXinLib.Model;

namespace WeixinWeb
{
    /// <summary>
    /// Summary description for WeixinMessageHandler
    /// </summary>
    public class WeixinMessageHandler : MessageHandler
    {
        public override ConfigModel GetConfig(HttpContext context)
        {
            string appId = "wx8b711cc5ca037d9e";
            ConfigModel config = ConfigManager.GetConfig(appId);

            return config;
        }

        /// <summary>
        /// 收到用户发来文本
        /// </summary>
        /// <param name="requestText"></param>
        /// <returns></returns>
        public override WeiXinLib.Model.Messages.ResponseMessage OnTextMessage(WeiXinLib.Model.Messages.RequestText requestText)
        {

            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnImageMessage(WeiXinLib.Model.Messages.RequestImage requestImage)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnVoiceMessage(WeiXinLib.Model.Messages.RequestVoice requestVoice)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnVideoMessage(WeiXinLib.Model.Messages.RequestVideo requestVideo)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnLocationMessage(WeiXinLib.Model.Messages.RequestLocation requestLocation)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnLinkMessage(WeiXinLib.Model.Messages.RequestLink requestLink)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventSubscribeMessage(WeiXinLib.Model.Messages.RequestEventSubscribe requestEventSubscribe)
        {

            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventUnSubscribeMessage(WeiXinLib.Model.Messages.RequestEventUnSubscribe requestEventUnSubscribe)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventScanMessage(WeiXinLib.Model.Messages.RequestEventScan requestEventScan)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventCustomerScanMessage(WeiXinLib.Model.Messages.RequestEventCustomerScan requestEventCustomerScan)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventLocationMessage(WeiXinLib.Model.Messages.RequestEventLocation requestEventLocation)
        {
            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventClickMessage(WeiXinLib.Model.Messages.RequestEventClick requestEventClick)
        {

            return null;
        }

        public override WeiXinLib.Model.Messages.ResponseMessage OnEventViewMessage(WeiXinLib.Model.Messages.RequestEventView requestEventView)
        {
            return null;
        }
    }
}