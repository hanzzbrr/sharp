using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLREvents
{
    internal sealed class Fax
    {
        private readonly string m_faxloc;

        public Fax(MailManager mm, string faxloc)
        {
            m_faxloc = faxloc;
            mm.NewMail += FaxMsg; //подписались на событие
        }

        //тот самый метод обратного вызова
        private void FaxMsg(Object sender, NewMailEventArgs e)
        {
            Console.WriteLine("Faxing mail message, Fax Location: "+m_faxloc);
            Console.WriteLine("From={0}, TO={1}, Subj={2}",e.From,e.To,e.Subject);
        }

        public void Unregister(MailManager mm)
        {
            mm.NewMail -= FaxMsg;
        }
    }
}
