using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 输出传递参数
{
    class Program
    {   
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个整数: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个整数: ");
            y = Convert.ToInt32(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            int a, b;
            p.getValues(out a, out b);
            Console.WriteLine("方法调用后, a = {0}", a);
            Console.WriteLine("方法调用后, b = {0}", b);
            Console.ReadKey();
        }
    }
}
