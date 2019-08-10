using System;
using System.Collections.Generic;


namespace Monte_Carlo
{
    class RandomNumGen
    {
        public List<Point> listOfPoints(int numOfPoints)
        {
            //creates an arraylist with a capacity of the amount of numbers we want to add
            List<Point> list = new List<Point>(numOfPoints);

            for (int x = 0; x < numOfPoints; x++)
            {
                Random ran = new Random();
                Point points = new Point(ran);
                list.Add(points);
            }
            return list;
        }

        
    }

}
