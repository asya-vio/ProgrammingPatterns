using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Ex05.ExternalLibs;

namespace Patterns.Ex05.SubEx_02
{
    class MailSenderListener : ISaveListener
    {
        MailSender sender;
        private string email;

        public void Update ()
        {
            sender.Send(email);
        }
    }
}
