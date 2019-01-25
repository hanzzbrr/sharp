using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLREvents.Example
{
    public class NewPackEventArgs : EventArgs
    {
        private readonly string m_from, m_to, m_content, m_delivery;
        public NewPackEventArgs(string from, string to, string content, string delivery)
        {
            m_from = from;
            m_to = to;
            m_content = content;
            m_delivery = delivery;
        }

        public string From { get { return m_from; } }
        public string To { get { return m_to; } }
        public string Content { get { return m_content; } }
        public string Delivery { get { return m_delivery; } }
    }
}
