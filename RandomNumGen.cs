using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ApproximatingPI
{
    class RandomNumGen
    {
        public ArrayList listOfPoints()
        {
            //creates an arraylist with a capacity of the amount of numbers we want to add
            ArrayList list = new ArrayList(10);

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
