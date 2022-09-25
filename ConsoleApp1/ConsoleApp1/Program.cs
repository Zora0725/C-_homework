using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 單行註解
            /*
                多行註解
            1234
            abcd
            
             */

            // 整數
            //含正負號的整數
            short amount;
            amount = 5;
            int a = 123;
            long count = 3000000000;
            //不含正負號
            ushort aa = 50000;
            uint aaa = 3000000000;
            ulong aaaa = 198977880000000;
            
            //浮點數
            float b = 123.45f;
            double c = 12345.6789; //預設

            //布林 Boolean
            bool d = true; //1
            bool dd = false; //0

            //字元
            char e = 'x';

            //字串
            string f = "Hello World";

            System.Console.WriteLine("Hello C# !!");
            System.Console.WriteLine("Hi, 這是第一個Console程式");
            Console.WriteLine("C# Demo");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("1. 主控台應用程式");
            System.Console.WriteLine();
            Console.Write("2. Windows Form程式");
            System.Console.WriteLine();
            Console.Write("3. Web 應用程式");
            Console.ResetColor();
            Console.WriteLine("Console特殊字元,控制字元");
            Console.WriteLine("\"雙引號\"");
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("\'單引號\'");
            Console.WriteLine("\t\t縮排");
            Console.WriteLine("如何換行\n我要換行\n這就是換行\n");
            Console.WriteLine("**** 變數的內容 ****");
            Console.WriteLine(amount);
            Console.WriteLine("變數 a:" + a); //字串合併
            Console.WriteLine(a + aa + b); //數值相加
            //變數插入字串
            Console.WriteLine($"float b: {b}\ndouble c: {c}\n");
            //字串插值
            Console.WriteLine("int a:{0}, double c:{2}, float b:{1},  bool d:{3}, char e:{4}, string f:{5}, 數值:{6}", a , b, c, d, e, f, 3000);

            System.Console.WriteLine();
            System.Console.WriteLine("按任意鍵結束");
            System.Console.ReadKey();

        }
    }
}
