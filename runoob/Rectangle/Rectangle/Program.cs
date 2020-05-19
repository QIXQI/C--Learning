using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{

    class Rectangle
    {
        double length;
        double width;

        public void AcceptDetails(double lenth, double width)
        {
            this.length = lenth;
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails(3, 4);
            r.Display();
            Console.ReadKey();
        }
    }
}
