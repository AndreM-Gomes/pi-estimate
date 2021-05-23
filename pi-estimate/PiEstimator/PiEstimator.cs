using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace piestimate.Properties
{
    public class PiEstimator
    {
        private Random random;
        private Point center;
        private Circle circle;
        private Square square;
        public PiEstimator()
        {
            this.random = new Random();
            this.center = new Point(1,1);
            var radius = 1;
            this.circle = new Circle(radius, this.center);
            this.square = new Square(new Point(0,0),radius * 2);
        }

        public Double GetPiEstimate(long attempts)
        {
            long pointsInsideCircle = 0;

            Parallel.For(0, attempts, new ParallelOptions { MaxDegreeOfParallelism = 4 },
            () => 0,
            (i, loop, localState) =>
            {
                var randomPointInsideSquare = this.square.GetRandomPointInside();
                if (this.circle.IsInside(randomPointInsideSquare))
                {
                    return localState + 1;
                }
                return localState + 0;
            },
                localState => Interlocked.Add(ref pointsInsideCircle, localState)
            );

            Double percentageOfOcuppiedArea = (double) pointsInsideCircle / (double) attempts;
            Double squareArea = this.square.GetArea();
            return percentageOfOcuppiedArea * this.square.GetArea();
        }
    }
}
