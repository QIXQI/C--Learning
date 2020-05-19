using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            // +
            string str1 = "hello" + " " + "world";
            Console.WriteLine(str1);

            // 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string str2 = new string(letters);
            Console.WriteLine(str2);

            // 方法返回值
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string str3 = string.Join(" ", sarray);
            Console.WriteLine(str3);

            // 格式化方法
            DateTime waiting = new DateTime(2020, 05, 19, 22, 56, 00);
            string str4 = string.Format("Message send at {0:t} on {0:D}", waiting);
            string str5 = string.Format("{0}", waiting);
            Console.WriteLine(str4);
            Console.WriteLine(str5);

            Console.ReadKey();
        }
    }
}