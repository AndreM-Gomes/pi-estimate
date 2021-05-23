using System;
namespace piestimate.Properties
{
    public struct Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double x { get; }
        public double y { get; }
    }
}
