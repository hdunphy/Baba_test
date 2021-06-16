using System;

namespace BabaRogaTest
{

    struct Rectangle
    {
        Point p1, p2, p3, p4;

        public Rectangle(Point pa, Point pb, Point pc, Point pd)
        {
            p1 = pa; p2 = pb; p3 = pc; p4 = pd;
        }

        public void Rotate(Point origin, float angle)
        {
            double angleRadians = angle * (Math.PI / 180);
            float sinTheta = (float)Math.Round(Math.Sin(angleRadians), 15);
            float cosTheta = (float) Math.Round(Math.Cos(angleRadians), 15);

            p1.RotatePoint(origin, cosTheta, sinTheta);
            p2.RotatePoint(origin, cosTheta, sinTheta);
            p3.RotatePoint(origin, cosTheta, sinTheta);
            p4.RotatePoint(origin, cosTheta, sinTheta);
        }

        public void Print()
        {
            Console.WriteLine($"{p1} {p2} {p3} {p4}");
        }
    }

    struct Point
    {
        float x, y;
        public Point(float _x, float _y)
        {
            x = _x; y = _y;
        }

        public void RotatePoint(Point origin, float cosTheta, float sinTheta)
        {
            float _x = x - origin.x;
            float _y = y - origin.y;

            x = (_x * cosTheta - _y * sinTheta) + origin.x;
            y = (_x * sinTheta + _y * cosTheta) + origin.y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 0);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(0, 1);
            Rectangle rect = new Rectangle(p1, p2, p3, p4);


            rect.Print();
            rect.Rotate(new Point(0, 0), 90);
            rect.Print();

            Console.WriteLine("---------------");

            Rectangle rect1 = new Rectangle(new Point(1, 1), new Point(1, 3), new Point(3, 3), new Point(3, 1));
            rect1.Print();
            rect1.Rotate(new Point(0, 0), 90);
            rect1.Print();
            rect1.Rotate(new Point(0, 0), 60);
            rect1.Print();
            rect1.Rotate(new Point(0, 0), 30);
            rect1.Print();
        }
    }
}
