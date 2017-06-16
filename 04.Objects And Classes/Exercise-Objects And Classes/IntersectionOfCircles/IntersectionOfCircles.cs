using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    public class IntersectionOfCircles
    {
        public static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Point c1 = new Point() { X = first[0], Y = first[1]};
            Point c2 = new Point() { X = second[0], Y = second[1] };
            Circle circle1 = new Circle() { center = c1, radius = first[2] };
            Circle circle2 = new Circle() { center = c2, radius = second[2] };
            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }

        public static bool Intersect(Circle circle1, Circle circle2)
        {
            double d = CalcDistance(circle1.center, circle2.center);
            if (d <= circle1.radius + circle2.radius)
            {
                return true;
            }
            return false;
        }

        public static double CalcDistance(Point P1, Point P2)
        {
            double a = P1.X - P2.X;
            double b = P1.Y - P2.Y;
            return Math.Sqrt(a * a + b * b);
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y  { get; set; }
    }

    public class Circle
    {
        public Point center { get; set; }
        public int radius { get; set; }
    }
}
