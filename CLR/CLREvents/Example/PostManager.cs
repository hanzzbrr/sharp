using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CLREvents.Example
{
    public class PostManager
    {
        public event EventHandler<NewPackEventArgs> NewPack;

        protected virtual void OnNewPack(NewPackEventArgs e)
        {
            EventHandler<NewPackEventArgs> temp = Volatile.Read(ref NewPack);
            if (temp != null) temp(this, e);
        }

        public void SimulateNewPack(string from, string to, string content, string delivery)
        {
            NewPackEventArgs e = new NewPackEventArgs(from, to, content, delivery);
            OnNewPack(e);
        }
    }
}
