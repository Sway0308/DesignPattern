using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class DecoratePattern : IDesignPattern
    {
        public void Run()
        {
            Console.WriteLine("----義大利餐館菜單----");

            Spaghetti normalSpaghetti = new NormalSpaghetti(); // 產生平民義大利麵
            normalSpaghetti = new Ham(normalSpaghetti); // 加點火腿
            normalSpaghetti = new Egg(normalSpaghetti); // 加點蛋
            normalSpaghetti = new Cheese(normalSpaghetti); // 加點起司
            Console.WriteLine("名稱:{0} 價錢:{1} 材料:{2}",
                normalSpaghetti.GetName(),
                normalSpaghetti.GetPrice(),
                normalSpaghetti.GetDescription());

            //Spaghetti spaghettiBolognese = new SpaghettiBolognese(); // 產生茄汁肉醬義大利麵
            //spaghettiBolognese = new MincedBeef(spaghettiBolognese);
            //spaghettiBolognese = new Tomato(spaghettiBolognese);
            //spaghettiBolognese = new Garlic(spaghettiBolognese);
            //Console.WriteLine("名稱:{0} 價錢:{1} 材料:{2}",
            //    spaghettiBolognese.GetName(),
            //    spaghettiBolognese.GetPrice(),
            //    spaghettiBolognese.GetDescription());

            Console.ReadLine();
        }
    }
}
