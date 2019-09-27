using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть степінь");
                int n = int.Parse(Console.ReadLine());
                double r = 1;
                for (int i = 1; i <= n; i++)
                {
                    r *= a;
                }
                Console.WriteLine(r);
            }
            catch {
                Console.WriteLine("Помилка вводу");
            }
            Console.ReadKey();
        }
    }
}
