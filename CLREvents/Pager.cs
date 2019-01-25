using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLREvents
{
    internal sealed class Pager
    {
        private readonly string m_owner;
        public Pager(MailManager mm, string owner)
        {
            m_owner = owner;
            mm.NewMail += PagerMsg;
        }

        public void PagerMsg(Object sender, NewMailEventArgs e)
        {
            Console.WriteLine("New Message *** ");
            Console.WriteLine("From={0}, To={1}, Subj={2}", e.From, e.To, e.Subject);
        }
        public void Unregister(MailManager mm)
        {
            mm.NewMail -= PagerMsg;
        }
    }
}
