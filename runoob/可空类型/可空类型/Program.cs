using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();       // 新建一个double?型数据，默认为null
            double? num4 = 3.1415926;

            bool? boolval = new bool?
                ();

            Console.WriteLine("{0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("{0}", boolval);
            Console.WriteLine();


            // ??
            // 如果第一个为null，返回第二个操作数，否则返回第一个操作数
            double? num21 = null;
            double? num22 = 3.14157;
            double num23;
            num23 = num21 ?? 5.34;
            Console.WriteLine(num23);
            num23 = num22 ?? 5.34;
            Console.WriteLine(num23);

            Console.ReadKey();
        }
    }
}
