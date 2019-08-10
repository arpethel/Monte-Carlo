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
            List<Point> list = new List<Point>(10000);

            for (int x = 0; x <= 10000; x++)
            {
                Random ran = new Random();
                Point points = new Point(ran);
                list.Add(points);
            }
            return list;
        }
    }
}
