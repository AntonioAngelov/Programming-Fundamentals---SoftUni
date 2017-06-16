using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    public class ClosestTwoPoints
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] points = new int[n][];
            for (int i = 0; i < n; i++)
            {
                points[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            Point[] arrPoints = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Point current = new Point();
                current.X = points[i][0];
                current.Y = points[i][1];
                arrPoints[i] = current;
            }

            Point[] closest = FindClosest(arrPoints);
            Console.WriteLine("{0:f3}", CalcDistance(closest[0], closest[1]));
            Console.WriteLine("({0}, {1})", closest[0].X, closest[0].Y);
            Console.WriteLine("({0}, {1})", closest[1].X, closest[1].Y);
        }

        public static double CalcDistance(Point P1, Point P2)
        {
            double a = P1.X - P2.X;
            double b = P1.Y - P2.Y;
            return Math.Sqrt(a * a + b * b);
        }

        public static Point[] FindClosest(Point[] arr)
        {
            Point[] closest = new Point[2];
            closest[0] = arr[0];
            closest[1] = arr[1];
            double distance = CalcDistance(arr[0], arr[1]);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (CalcDistance(arr[i], arr[k]) < distance)
                    {
                        closest[0] = arr[i];
                        closest[1] = arr[k];
                        distance = CalcDistance(arr[i], arr[k]);
                    }
                }
            }
            return closest;

        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
