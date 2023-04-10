using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace FXFellowDashboard
{
    class SMSParam
    {
        public string message;
        public string toPhone;
        //public string fromPhone;
    }

    class SendSMS
    {
        public void send_sms(object param)
        {
            string message = ((SMSParam)param).message;
            string to_phone = ((SMSParam)param).toPhone;

            try
            {
                string accountSid = "ACeb1fcca75c4214357d2c154a33105b20";
                string authToken = "0fbfde609d5f5454e551917ec4e4ef5e";

                TwilioClient.Init(accountSid, authToken);

                var to = new PhoneNumber(to_phone);

                // var to = new PhoneNumber("whatsapp:+41787083360"); //werner
                // var to = new PhoneNumber("+41774639070"); //Larissa
                // var to = new PhoneNumber("+447788709724"); //England

                var from = new PhoneNumber("+41798076089");

                var mess = MessageResource.Create(
                    to: to,
                    from: from,
                    body: message);

                Settings.Log.Info("Send SMS success");
            }
            catch(Exception ex)
            {
                Settings.Log.Error("Send SMS failed: " + ex.ToString());
            }
        }
    }
}
