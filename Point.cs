using System;

namespace Monte_Carlo
{
    struct Point
    {
        public double x { get; }
        public double y { get; }
        public string color { get; set; }

        public Point(Random r)
        {
            x = r.NextDouble();
            y = r.NextDouble();
            color = "";
        }

        public override string ToString()
        {
            return color;
        }
    }
}
