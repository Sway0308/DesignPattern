using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Customer : IObserver
    {
        public string MyName { private get; set; }

        public Customer(string pName)
        {
            MyName = pName;
        }

        // 更新最新消息
        public void Update(string pMessage)
        {
            Console.WriteLine("   {0} receive a new message:{1}", MyName, pMessage);
        }
    }
}
