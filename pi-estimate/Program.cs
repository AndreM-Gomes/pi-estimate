using System;
using piestimate.Properties;

namespace piestimate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var attempts = 10000;
            Console.WriteLine($"Estimating pi with {attempts} attempts");
            var estimator = new PiEstimator();
            Console.WriteLine($"Estimated value of pi: {estimator.GetPiEstimate(attempts)}");

        }
    }
}