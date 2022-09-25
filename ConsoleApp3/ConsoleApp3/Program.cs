using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 120;
            int y = 120;

            //if .. else 條件判斷式
            if (x > y)
                { //true
                    Console.WriteLine("x 大於 y");
                } 
            else
                { //false
                    Console.WriteLine("x 小於或等於 y");
                }

            Console.WriteLine("-----------------------------");

            if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else
            {
                if (x == y)
                {
                    Console.WriteLine("x 等於 y");
                }
                else
                {
                    Console.WriteLine("x 小於 y");
                }
            }

            Console.WriteLine("-----------------------------");
            // else if
            if (x == y)
            {
                Console.WriteLine("x 等於 y");
            }
            else if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else if (x < y)
            {
                Console.WriteLine("x 小於 y");
            }
            else
            {
                Console.WriteLine("不存在");
            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine("if ... else 簡式");
            int w = 2;
            int s;

            if (w < 0)
            {
                s = -1;
            } else
            {
                s = w * 2;
            }

            Console.WriteLine("s:" + s);

            //if ... else 簡式
            s = (w < 0) ? -1 : (w * 2);
            Console.WriteLine("簡式 s:" + s);

            //練習: 任意三個數比大小
            // int a = 12;
            // int b = 3;
            // int c = 5;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("**** 甜點選擇 ****");
            Console.WriteLine("甜點選擇:(a: 布丁, b: 冰淇淋, c: 奶酪, d: 紅豆湯, ff: 雞蛋糕)");
            Console.WriteLine("輸入完成請按Enter");
            string ss = Console.ReadLine();

            switch(ss)
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
            Console.WriteLine("\n\n按任意鍵結束");
            Console.ReadKey();
        }
    }
}
