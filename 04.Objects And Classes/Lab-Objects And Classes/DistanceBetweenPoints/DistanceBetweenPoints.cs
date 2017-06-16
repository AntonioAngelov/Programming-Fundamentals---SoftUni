using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main(string[] args)
        {
            int[] p1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] p2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point P1 = new Point();
            Point P2 = new Point();
            P1.X = p1[0];
            P1.Y = p1[1];
            P2.X = p2[0];
            P2.Y = p2[1];
            Console.WriteLine("{0:f3}", CalcDistance(P1, P2));

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
        public int Y { get; set; }
    }
}
