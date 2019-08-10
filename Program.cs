using System;
using System.Collections.Generic;

namespace Monte_Carlo
{
    class Program
    {
        public double gethypotenuse(Point point)
        {
            return Math.Sqrt(Math.Pow(point.x, 2) + Math.Pow(point.y, 2));
        }
        //the return type is a tuple that can hold multiple values of any type
        public (double,int) Calculate(List<Point> list)
        {
            double red = 0;
            double blue = 0;
            double estimatedPi;
            for (int i = 0; i < list.Count; i++)
            {
                Point p = new Point();
                p = list[i];
                double hypotenuse = gethypotenuse(p);
                
                if (hypotenuse < 1)
                {
                    p.color = "red";
                    red++;
                }

                if (hypotenuse >= 1)
                {
                    p.color = "blue";
                    blue++;
                }
            }
            Console.WriteLine($"# of points in the red: {red}\n# of points in the blue: {blue}\n");
            estimatedPi = (red / blue);
            //here we are using a tuple to return 2 seperate values, our extimated pi and the sample size(which is the size of the list)
            return (estimatedPi, list.Count);
        }

        //public double 
        static void Main(string[] args)
        {
            RandomNumGen list = new RandomNumGen();
            Program t = new Program();
            
            //here we create a tuple that stores the first returned value as estimated pi and the 2nd returned value as the length 
            (double estimatedPi, int length) = t.Calculate(list.listOfPoints(10000));
            double deviation = Math.PI - estimatedPi;
            Console.WriteLine($"Estimated pi is {estimatedPi} our deviation is {deviation}\nsample size was {length}");
        }
    }
}
