using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using SendGrid.SmtpApi;
using SendGrid.Resources;
using System.Net.Mail;
using System.Configuration;


namespace RailinBikeRacks.WEB
{
    public static class EmailProvider
    {

        public static bool Send(string recipient, string subject, string message, string senderEmail = "the.languagefactory1@gmail.com", string sender = "the.languagefactory1@gmail.com")
        {

            try
            {
                
                var myMessage = new SendGrid.SendGridMessage();
                myMessage.AddTo(recipient);
                myMessage.From = new MailAddress(sender, senderEmail);
                myMessage.Subject = subject;
                myMessage.Html = message;

                
                var transportWeb = new SendGrid.Web(ConfigurationManager.AppSettings["APIKey"]);
                
                transportWeb.DeliverAsync(myMessage);

            }
            catch (Exception ex)
            {
                throw ex;
                return false;
            }
            return true;

        }
    }
}
