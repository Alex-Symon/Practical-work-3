using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть число k");
                int k = int.Parse(Console.ReadLine());
                double r = 0;
                for (int i = 1; i <= n; i++)
                {
                    r = r + Math.Pow(i, k);
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
