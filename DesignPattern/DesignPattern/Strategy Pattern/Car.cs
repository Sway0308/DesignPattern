using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy_Pattern
{
    public abstract class Car
    {
        public virtual void SpeedUp()
        {
            Console.WriteLine("加速中");
        }

        public virtual void SpeedDown()
        {
            Console.WriteLine("減速中");
        }

        public virtual void UseNOS()
        {
            Console.WriteLine("開啟氮氣加速");
        }
    }

    public class PorscheCar : Car
    {
        private ISpeedUpSet _speedUp;
        private ISpeedDownSet _speedDown;
        private IItemSet _item;
        private IAtkMode _atkMode;

        public PorscheCar(ISpeedUpSet speedUp, ISpeedDownSet speedDown, IItemSet item, IAtkMode atkMode)
        {
            this._speedUp = speedUp;
            this._speedDown = speedDown;
            this._item = item;
            this._atkMode = atkMode;
        }

        public override void SpeedUp()
        {
            this._speedUp.SpeedUp();
        }

        public override void SpeedDown()
        {
            this._speedDown.SpeedDown();
        }

        public void UseItem()
        {
            this._item.UseItem();
        }

        public void Atk()
        {
            this._atkMode.Atk();
        }
    }

    public class AmbulanceCar : Car
    {
    }
}
