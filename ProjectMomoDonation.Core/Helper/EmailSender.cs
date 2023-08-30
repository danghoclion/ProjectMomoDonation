using ProjectMomoDonation.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMomoDonation.Core.Helper
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string messsage)
        {
            var mail = "ledanghoc1102@gmail.com";
            var pwd = "ouddzrrprmkaqtge";

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pwd)
            };

            return client.SendMailAsync(new MailMessage(
                    from: mail,
                    to: email,
                    subject,
                    messsage
                ));
        }
    }
}