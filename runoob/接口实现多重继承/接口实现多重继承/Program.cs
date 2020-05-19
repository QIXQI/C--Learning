using System;

namespace 接口实现多重继承
{
    class Shape
    {
        protected double length;
        protected double width;

        public void setLength(double l)
        {
            length = l;
        }

        public void setWidth(double w)
        {
            width = w;
        }
    }

    public interface PaintCost
    {
        double GetCost(double area);
    }

    class Rectangle: Shape, PaintCost
    {
        public double GetArea()
        {
            return length * width;
        }

        public double GetCost(double area)
        {
            return area * 70;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.setLength(5);
            r.setWidth(7);
            double area = r.GetArea();
            double cost = r.GetCost(area);

            Console.WriteLine("area: {0}", area);
            Console.WriteLine("cost: {0}", cost);

            Console.ReadKey();

        }
    }
}
