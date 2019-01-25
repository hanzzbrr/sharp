using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLREvents.Example
{
    public class PostService
    {
        public PostService(PostManager pm)
        {
            pm.NewPack += PostMsg;
        }

        private void PostMsg(Object sender, NewPackEventArgs e)
        {
            Console.WriteLine("Message about new pack");
            Console.WriteLine("From={0}, TO={1}, Content={2}, Delivery={3}",e.From, e.To, e.Content, e.Delivery);
        }
    }
}
