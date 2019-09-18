using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class Spaghetti
    {
        public string name = "未知名稱";
        public string description = "未知配料";

        public abstract int GetPrice();

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual string GetDescription()
        {
            return this.description;
        }
    }
}
