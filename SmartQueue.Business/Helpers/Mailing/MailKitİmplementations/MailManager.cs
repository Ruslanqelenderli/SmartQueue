using System.Net.Mail;

using MimeKit;
using Microsoft.Extensions.Configuration;

namespace SmartQueue.Business.Helpers.Mailing.MailKitİmplementations
{
    public class MailManager : IMailService
    {
       

       

        public bool SendMail(Mail mail,MailSettings _mailSettings)
        {
            var mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(_mailSettings.SenderEmail);
            mailMessage.To.Add(new MailAddress(mail.ToEmail));

            mailMessage.Subject = mail.Subject;
            mailMessage.IsBodyHtml = true;
            
            mailMessage.Body = mail.TextBody;

            SmtpClient client = new SmtpClient();

            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(_mailSettings.SenderEmail, _mailSettings.Password);
            client.Host = _mailSettings.Host;
            client.Port = _mailSettings.Port;
            client.EnableSsl = _mailSettings.EnableSSL;


            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
            return false;
        }
    }
}
