using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLREvents
{
    //определение типа для хранения информации
    //т.е. здесь мы храним дополнительную информацию, передаваемую получателеям уведомлений о событии
    internal class NewMailEventArgs : EventArgs
    {
        private readonly string m_from, m_to, m_subject; //отправитель, получатель, тема

        public NewMailEventArgs(string from, string to, string subject) //просто конструктор в котором инициализируем поля
        {
            m_from = from; m_to = to; m_subject = subject;
        }
        //свойства для обращения к полям
        public string From { get { return m_from; } } 
        public string To { get { return m_to; } }
        public string Subject { get { return m_subject; } }
    }
}
