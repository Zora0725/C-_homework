using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While 迴圈
            int i = 0;
            while (true)
            {
                i += 1;
                Console.WriteLine("Hello World." + i);
                if (i >= 10) {
                    break;
                }
            }
            Console.WriteLine("--------------------------------------");
            int d = 1;
            while (d <= 10)
            {
                Console.WriteLine("d:" + d);
                d += 1;
            }
            Console.WriteLine("--------------------------------------");
            do
            {
                Console.WriteLine("Hello C#");
            }
            while (false);
            Console.WriteLine("--------------------------------------");
            int g = 1;
            do
            {
                Console.WriteLine("g:" + g);
                g += 1;
            }
            while (g <= 10);
            Console.WriteLine("--------------------------------------");


            Console.WriteLine("\n\n按任意鍵結束");
            Console.ReadKey();
        }
    }
}
