using System;
using System.Collections;
using System.Collections.Generic;

namespace Monte_Carlo
{
    class Program
    {
        public double GetHypotenuse(Point p)
        {
            return Math.Sqrt(p.x * p.x + p.y * p.y);
        }
        public double Calculate(List<Point> list)
        {
            double red = 0;
            double blue = 0;

            for (int i = 0; i < list.Count; i++)
            {
                Point p = new Point();
                p = list[i];

                if (GetHypotenuse(p) < 1)
                {
                    p.color = "Red";
                    red++;
                }

                if (GetHypotenuse(p) >= 1)
                {
                    p.color = "Blue";
                    blue++;
                }
            }
            return red / blue;
        }

        static void Main(string[] args)
        {
            RandomNumGen list = new RandomNumGen();
            Program t = new Program();

            Console.WriteLine(t.Calculate(list.listOfPoints()));
        }
    }
}
