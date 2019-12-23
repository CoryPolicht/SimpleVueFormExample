using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using SimpleDotNetWebServiceExample.Models;

namespace SimpleDotNetWebServiceExample.Services
{
    public class EmailService
    {

        public void SendEmail(FormData data)
        {
            var message = new MailMessage();
            message.Body = data.ToString();
            message.Sender = new MailAddress("Something@company.com");

            using (var smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
                smtpClient.Send(message);
                //this using statement could hide an exception fyi
            }
        }
    }
}
