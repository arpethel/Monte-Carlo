using System;
using System.Collections.Generic;
using System.Text;

namespace ApproximatingPI
{
    struct Point
    {

        private double x { get; }
        private double y { get; }
        public string color;

        public Point(Random r)
        {
            this.x = r.NextDouble();
            this.y = r.NextDouble();
            this.color = "";
        }

        public override string ToString()
        {
            return color;
        }
    }
}
