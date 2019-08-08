using System;
using System.Collections;
using System.Collections.Generic;

namespace Monte_Carlo
{
    class Program
    {
        //public double GetHypotenuse()
        //{
        //    return Math.Sqrt(this.x * this.x + this.y * this.y);
        //}
        public void Calculate(List<Point> list)
        {

            // TODO
            for (int i = 0; i < list.Count; i++)
            {
                Point p = new Point();
                p = list[i];
                Console.WriteLine(p.x);
            }
            //if (GetHypotenuse() < 1)
            //{
            //    // Pink
            //}

            //if (GetHypotenuse() >= 1)
            //{
            //    // Orange
            //}
            
        }

        //public double 
        static void Main(string[] args)
        {
            RandomNumGen list = new RandomNumGen();
            Program t = new Program();
            
            t.Calculate(list.listOfPoints());
        }
    }
}
