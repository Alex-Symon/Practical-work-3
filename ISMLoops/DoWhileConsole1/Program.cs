using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число");
                double r = 0;
                int n;
                do
                {
                    n = int.Parse(Console.ReadLine());
                    r = r + n;
                }
                while (n != 0);

                Console.WriteLine(r);
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных");
            }
            Console.ReadKey();
        }
    }
}
