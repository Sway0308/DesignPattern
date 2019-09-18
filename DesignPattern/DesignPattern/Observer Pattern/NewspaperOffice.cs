using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class NewspaperOffice : ISubject
    {
        List<IObserver> lstObservers; // 使用List來存放觀察者名單

        public NewspaperOffice()
        {
            lstObservers = new List<IObserver>();
        }

        // 加入觀察者
        public void RegisterObserver(IObserver pObserver)
        {
            lstObservers.Add(pObserver);
        }

        // 移除觀察者
        public void RemoveObserver(IObserver pObserver)
        {
            if (lstObservers.IndexOf(pObserver) >= 0)
                lstObservers.Remove(pObserver);
        }

        // 發送通知給在監聽名單中的觀察者
        public void notifyObservers(string pContent)
        {
            foreach (IObserver observer in lstObservers)
            {
                observer.Update(pContent);
            }
        }

        // 訂閱報紙
        public void SubscribeNewspaper(IObserver pCustomer)
        {
            RegisterObserver(pCustomer);
        }

        // 取消訂閱報紙
        public void UnsubscribeNewspaper(IObserver pCustomer)
        {
            RemoveObserver(pCustomer);
        }

        // 發送新消息
        public void SendNewspaper(string pContent)
        {
            Console.WriteLine("Send News..");
            notifyObservers(pContent);
        }
    }
}
