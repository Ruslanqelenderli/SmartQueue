using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartQueue.Business.Helpers.Mailing
{
    public interface IMailService
    {
        bool SendMail(Mail mail,MailSettings mailSettings);
    }
}
