using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Monte_Carlo
{
    class RandomNumGen
    {
        public List<Point> listOfPoints()
        {
            //creates an arraylist with a capacity of the amount of numbers we want to add
            List<Point> list = new List<Point>(10);

            for (int x = 0; x <= 10; x++)
            {
                Random ran = new Random();
                Point points = new Point(ran);
                list.Add(points);
            }
            return list;
        }
    }
}
