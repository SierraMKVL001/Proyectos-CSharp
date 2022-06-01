using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailService
{
    class SystemSupportMail : MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "SoporteSystemPacsComp@gmail.com";
            password = "PacsComp4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initialiceSmtpClient();
        }
    }
}
