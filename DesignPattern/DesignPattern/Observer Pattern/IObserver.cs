using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver pObserver);
        void RemoveObserver(IObserver pObserver);
        void notifyObservers(string pContent);
    }
    public interface IObserver
    {
        void Update(string pMessage);
    }
}
