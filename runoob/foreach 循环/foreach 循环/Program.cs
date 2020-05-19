using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace foreach_循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8 };
            // foreach 循环
            foreach (int element in fibarray)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
