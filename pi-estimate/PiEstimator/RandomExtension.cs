using System;
namespace piestimate.Properties
{
    public static class RandomExtension
    {
        public static Double NextBetween(this Random random, Double min, Double max)
        {
            if (min.Equals(0))
            {
                return random.NextDouble() * max;
            }
            return random.NextDouble() * (max - min + 1) + min;
        }

        public static Point RandomPointFromZeroTo(this Random random,Double ceillingX, Double ceillingY){
            return new Point(random.NextBetween(0,ceillingX),random.NextBetween(0,ceillingY));
        }
    }
}
