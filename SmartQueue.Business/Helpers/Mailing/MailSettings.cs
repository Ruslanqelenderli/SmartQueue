using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Helpers.Mailing
{
    public class MailSettings
    {
        public int Port { get; set; }
        public string Host { get; set; }
        public bool EnableSSL { get; set; }
        public string SenderEmail { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MailSettings()
        {
        }

        public MailSettings(string server, int port, string senderFullName, string senderEmail, string userName,
                            string password)
        {
            Port = port;
            SenderEmail = senderEmail;
            UserName = userName;
            Password = password;
        }
    }
}
