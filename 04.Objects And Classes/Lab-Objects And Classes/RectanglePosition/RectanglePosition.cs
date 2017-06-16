using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    public class RectanglePosition
    {
        public static void Main(string[] args)
        {
            var r1 = Rectangle.ReadRectangle();
            var r2 = Rectangle.ReadRectangle();
            if (Rectangle.FirstIsInsideSecond(r1, r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }

    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Hight { get; set; }
        public double Bottom
        {
            get
            {
                return this.Top + this.Hight;
            }
        }

        public double Right
        {
            get
            {
                return this.Left + this.Width;
            }
        }

        public static Rectangle ReadRectangle()
        {
            var tokens = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var rect = new Rectangle() { Top = tokens[1], Left = tokens[0], Width = tokens[2], Hight = tokens[3] };

            return rect;
        }

        public static bool FirstIsInsideSecond(Rectangle r1, Rectangle r2)
        {
            var inside = r1.Left >= r2.Left && r1.Right <= r2.Right && r1.Top >= r2.Top && r1.Bottom <= r2.Bottom;
            return inside;
        }

        
    }
}
