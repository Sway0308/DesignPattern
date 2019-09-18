using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public interface ISpeedUpSet
    {
        void SpeedUp();
    }
    public interface ISpeedDownSet
    {
        void SpeedDown();
    }
    public interface IItemSet
    {
        void UseItem();
    }
    public interface IAtkMode
    {
        void Atk();
    }
}
