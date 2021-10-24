using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CLREvents
{
    internal class MailManager
    {
        //EventHandler<>является делегатом
        public event EventHandler<NewMailEventArgs> NewMail; //событие поддерживаемое данным классом
        
        //
        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            EventHandler<NewMailEventArgs> temp = Volatile.Read(ref NewMail); //что-то там с потоками

            if (temp != null) temp(this, e);
        }

        public void SimulateNewMail(string from, string to, string subject)
        {
            //создание объекта, хранящего информацию, которую нужно передать получателям
            NewMailEventArgs e = new NewMailEventArgs(from, to, subject);
            OnNewMail(e);   //генерация события
        }
    }
}
