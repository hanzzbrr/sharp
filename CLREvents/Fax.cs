using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLREvents
{
    internal sealed class Fax
    {
        public Fax(MailManager mm)
        {
            mm.NewMail += FaxMsg;
        }

        private void FaxMsg(Object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Faxing mail message");
            Console.WriteLine("From={0}, TO={1}, Subj={2}",e.From,e.To,e.Subject);
        }

        public void Unregister(MailManager mm)
        {
            mm.NewMail -= FaxMsg;
        }
    }
}
