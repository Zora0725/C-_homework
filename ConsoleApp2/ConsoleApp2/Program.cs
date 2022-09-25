using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //算術運算子
            int x = 9;
            int y = 4;
            int z;

            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;
            z = x % y;
            z = -y;
            z = x + y * y;
            z = (x - y) / y;

            Console.WriteLine("**** 算術運算 ****");
            Console.WriteLine("z的值為:" + z);

            Console.WriteLine("**** 整數與浮點關係 ****");
            int x2 = 5;
            double y2 = 1.2345;
            double z2;
            z2 = x2 * y2;
            z2 = x2 / y2;
            Console.WriteLine("z2的值:" + z2);

            //算術指定運算子
            int c = 250;
            int d = 100;
            //c = c + 3;
            //c += 3; //253
            //c -= 3; //247
            //c *= 3; //750
            //c /= 3; //83
            c %= 3; 

            Console.WriteLine("**** 指定運算子 ****");
            Console.WriteLine("c的值為:" + c);

            //遞增與遞減運算子
            int r = 8;
            r++;  // r = r + 1;
            r--;  // r = r - 1;
            Console.WriteLine("**** 遞增與遞減運算子 ****");
            Console.WriteLine("r值:" + r);

            //關係運算式
            double m = 85.23;
            double n = 45.56;
            bool compare;

            Console.WriteLine("**** 關係與條件運算 ****");

            compare = m == n;
            compare = m != n;
            compare = m >= n;
            compare = m > n;
            compare = m <= n;
            compare = m < n;

            Console.WriteLine("Compare:" + compare);
            Console.WriteLine("----------------------------------");
            //複合關係運算式, 達成條件
            float p = 56.78f;
            float w = 92.31f;
            bool logic;

            logic = (p < w) && (p >= 50.0f); //AND, true
            logic = (p > 60.0f) && (p != w); //false
            logic = (w <= 80.0f) || (p <= w); //true
            logic = (p > w) || (w < 20.0f); //false
            logic = (p > 40.0f) && (w < 120.0f) && (p == w); //false
            logic = (p > 10.0f) || (w > 75.0) || (p >= w); //true
            logic = ((p > 20.0f) || (w < 50.0f)) && (p < w); //true
            logic = !(p < w);

            Console.WriteLine("logic:" + logic);

            Console.WriteLine("\n\n按任意鍵結束");
            Console.ReadKey();
        }
    }
}
