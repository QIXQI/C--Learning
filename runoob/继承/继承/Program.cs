using System;

namespace 继承
{
    // 基类
    class Rectangle
    {
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("area: {0}", GetArea());
        }
    }


    // 子类
    class Tabletop: Rectangle
    {
        private double cost;

        // 父类的初始化
        public Tabletop(double l, double w) : base(l, w)
        {

        }

        public double GetCost()
        {
            cost = GetArea() * 70;
            return cost;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("cost: {0}", GetCost());
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadKey();
        }
    }
}
