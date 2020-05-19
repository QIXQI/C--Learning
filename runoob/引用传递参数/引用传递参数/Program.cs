using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 引用传递参数
{
    class Program
    {
        public void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int a = 100;
            int b = 200;

            p.swap(ref a, ref b);

            Console.WriteLine("交换后a: {0}", a);
            Console.WriteLine("交换后b: {0}", b);

            Console.ReadKey();
        }
    }
}
