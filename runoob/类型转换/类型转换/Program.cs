using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换
{
    /// <summary>
    /// 对于数字类型直接使用(int)强制转换，整数型字符串使用int.Parse()转换，其他的可以使用Convert.ToInt32()
    /// </summary>

    class Program
    {
        class Class1
        {

        }

        class Class2 : Class1       // Class2 是 Class1 的子类
        {

        }


        static void Main(string[] args)
        {
            // 第一种
            // (int) 只能转换数字类型，如float、double
            double d = 2323.23;
            int i = (int)d;
            Console.WriteLine(i);
            Console.WriteLine();

            // 第二种
            float f = 43.232f;
            bool b = true;
            Console.WriteLine(f.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine();

            // 类转换
            Class1 c1 = new Class2();       // 隐式转换
            Console.WriteLine("隐式转换: {0}", c1 is Class1);
            Console.WriteLine("隐式转换: {0}", c1 is Class2);
            Class1 c11 = new Class1();
            Class2 c22 = c11 as Class2;     // 使用as显示转换
            Console.WriteLine("显式转换: {0}", c22 is Class1);
            Console.WriteLine("显式转换: {0}", c22 is Class2);
            Console.WriteLine();

            // 使用Convert.ToInt32(Object) 和 int.Parse(string)
            // string
            int i11 = Convert.ToInt16("123");
            Console.WriteLine(i11);
            int i12 = int.Parse("123");
            Console.WriteLine(i12);
            // null
            // Console.WriteLine("Parse of null: {0}", int.Parse(null));           // 异常
            Console.WriteLine("Convert of null: {0}", Convert.ToInt32(null));   // 0
            // Convert 对 double 四舍五入
            // Convert 四舍五入时，对于两个整数正中间的数字，返回二者中的偶数
            // 如：3.5 -> 4; 4.5 -> 4; 4.6 -> 5
            double d11 = 1.35;
            double d12 = 1.65;
            double d13 = 4.5;
            Console.WriteLine("Convert of {0}: {1}", d11, Convert.ToInt32(d11));
            Console.WriteLine("Convert of {0}: {1}", d12, Convert.ToInt32(d12));
            Console.WriteLine("Convert of {0}: {1}", d13, Convert.ToInt32(d13));
            Console.WriteLine();
            // int.Parse("123.234")
            // Console.WriteLine(int.Parse("123.234"));     // 异常


            // 使用 TryParse，不会出现异常
            string s21 = "abcd";
            // int i21 = Convert.ToInt16(s21);      // 异常
            // int i22 = int.Parse(s21);            // 异常
            int i23;
            bool b23 = int.TryParse(s21, out i23);
            // Console.WriteLine(i21);
            // Console.WriteLine(i22);
            Console.WriteLine("{0}: {1}, {2}", s21, b23, i23);

            



            Console.ReadKey();
        }
    }
}
