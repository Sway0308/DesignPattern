using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Ham : CondimentDecorator
    {
        Spaghetti spaghetti;

        public Ham(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",火腿";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 38;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }

    public class Egg : CondimentDecorator
    {
        Spaghetti spaghetti;

        public Egg(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",蛋";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 5;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }

    public class Cheese : CondimentDecorator
    {
        Spaghetti spaghetti;

        public Cheese(Spaghetti pSpaghetti)
        {
            this.spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return spaghetti.GetDescription() + ",起司";
        }

        public override int GetPrice()
        {
            return spaghetti.GetPrice() + 20;
        }

        public override string GetName()
        {
            return spaghetti.GetName();
        }
    }
}
