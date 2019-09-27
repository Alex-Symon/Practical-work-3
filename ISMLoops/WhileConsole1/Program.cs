using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число n");
                int n = int.Parse(Console.ReadLine());
                int k = 0;
                if (n > 1)
                {
                    while (Math.Pow(3, k) <= n)
                    {
                        k++;
                    }
                    Console.WriteLine(k);
                }
                else
                    Console.WriteLine("Помилка вводу");
            }
            catch {
                Console.WriteLine("Помилка вводу");
            }
            Console.ReadKey();
        }
    }
}
