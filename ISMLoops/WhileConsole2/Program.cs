using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть відсоток P");
                int P = int.Parse(Console.ReadLine());
                int k = 0;
                double s = 10;
                if (P > 0 && P < 50)
                {
                    while (s < 200)
                    {
                        s += s * (P / 100.0);
                        k++;
                    }

                    Console.WriteLine("Кількість днів" + k);
                    Console.WriteLine("Сумарний пробіг" + s);
                }
                else
                    Console.WriteLine("Помилка введення");
            }
            catch {
                Console.WriteLine("Помилка введення");
            }
            Console.ReadKey();
        }
    }
}
