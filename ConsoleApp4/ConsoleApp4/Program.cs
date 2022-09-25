using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //迴圈 Loop
            // for 迴圈 

            for (int i = 1; i <= 20; i += 1) //step 為 1
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("------------------------------------");
            for (int i = 0; i <= 40; i += 2) // 偶數 0...40
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("------------------------------------");
            // 輸出 10...1
            for (int i = 10; i >= 1; i -= 1)
            {
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("------------------------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                if (i > 10)
                {
                    break; //中斷迴圈
                }
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("------------------------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                if (i == 8)
                {
                    continue; //跳過這次的迴圈執行
                }
                Console.WriteLine("i:" + i);
            }
            Console.WriteLine("------------------------------------");
            for (int i = 1; i <= 9; i += 1)
            {
                for (int j = 1; j <= 9; j += 1)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
            }
            Console.WriteLine("------------------------------------");
            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= 20; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
            int n = 0;

            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= 20; j += 1)
                {
                    n += 1;
                    Console.Write($"[{n}]");
                    //練習: 如何補空白表格對齊
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------------");
            for (int i = 1; i <= 10; i += 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //練習: 輸出等腰三角形, 菱形
            Console.WriteLine("------------------------------------");

            //練習: 計算質數(prime), 列出指定範圍的質數
            //int intMin = 1;
            //int intMax = 100;
            //質數: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43 ...
            //進階思考: 沒有上限質數怎麼寫?順便統計, 已跑多少質數

            Console.WriteLine("\n\n按任意鍵結束");
            Console.ReadKey();
        }
    }
}
