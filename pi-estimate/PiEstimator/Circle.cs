using System;
namespace piestimate.Properties
{
    public class Circle
    {
        public Circle(double radius, Point center)
        {
            this.radius = radius;
            this.center = center;
        }

        double radius { get; }
        Point center { get; }

        public bool IsInside(Point point)
        {
            return Math.Pow(point.x - this.center.x, 2) + Math.Pow(point.y - this.center.y, 2) < Math.Pow(radius, 2);
        }
    }
}
