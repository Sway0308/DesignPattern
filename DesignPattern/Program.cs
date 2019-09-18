using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var designPattern = typeof(IDesignPattern);
            var assemblies = AppDomain.CurrentDomain.GetAssemblies()
                                                    .SelectMany(x => x.GetTypes())
                                                    .Where(x => designPattern.IsAssignableFrom(x) && x != designPattern);
            var dic = new Dictionary<int, string>();
            for (int i = 0; i < assemblies.Count(); i++)
            {
                dic.Add(i + 1, assemblies.ElementAt(i).FullName);
            }

            StartTest(dic);
        }

        private static void StartTest(Dictionary<int, string> dic)
        {
            Console.Clear();

            foreach (var key in dic.Keys)
            {
                Console.WriteLine($"{key}. {dic[key]}");
            }

            var ans = Console.ReadLine();
            if (ans.Equals("Exit", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("bye bye");
                Console.ReadKey();
                return;
            }
            else if (!int.TryParse(ans, out var number))
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
            }
            else if (!dic.ContainsKey(number))
            {
                Console.WriteLine("Wrong number");
                Console.ReadKey();
            }
            else
            {
                DoTest(dic[number]);
            }

            StartTest(dic);
        }

        private static void DoTest(string assemblyName)
        {
            var sol = GetSolution(assemblyName);
            var strTime = DateTime.Now;
            Console.WriteLine(strTime);
            sol.Run();
            var endTime = DateTime.Now;
            Console.WriteLine(endTime);
            Console.WriteLine("Total time：" + (endTime - strTime).TotalMilliseconds);
        }

        private static IDesignPattern GetSolution(string assemblyName)
        {
            var type = Type.GetType(assemblyName);
            var sol = Activator.CreateInstance(type) as IDesignPattern;
            return sol;
        }
    }
}
