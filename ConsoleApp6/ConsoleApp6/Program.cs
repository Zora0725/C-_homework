using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //While 迴圈應用
                //甜點選單
                Console.Clear();
                Console.WriteLine("===== 超好吃下午茶 =====");
                Console.WriteLine("**** 甜點選擇 ****");
                Console.WriteLine("甜點選擇:(a: 布丁, b: 冰淇淋, c: 奶酪, d: 紅豆湯, ff: 雞蛋糕)");
                Console.WriteLine("結束選單請輸入exit");
                Console.WriteLine("輸入完成請按Enter");
                string ss = Console.ReadLine();

                if (ss == "exit")
                {
                    break;
                }

                switch (ss)
                {
                    case "a":
                        Console.WriteLine("您選了布丁 60 元");
                        break;
                    case "b":
                        Console.WriteLine("您選了冰淇淋 55 元");
                        break;
                    case "c":
                        Console.WriteLine("您選了奶酪 70 元");
                        break;
                    case "d":
                        Console.WriteLine("您選了紅豆湯 40 元");
                        break;
                    case "ff":
                        Console.WriteLine("您選了雞蛋糕 35 元");
                        break;
                    default:
                        Console.WriteLine("無此產品");
                        break;
                }

                Console.WriteLine("-------------------------------");
                Console.WriteLine("\n\n按任意鍵重新選擇");
                Console.ReadKey();
            }
        }
    }
}
