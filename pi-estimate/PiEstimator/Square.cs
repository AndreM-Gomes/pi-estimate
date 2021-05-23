using System;
namespace piestimate.Properties
{
    public class Square
    {
        double sideLength { get; }

        /*
            Considerando o quadrado de vértices = {A,B,C,D}, seu sideLength
            será o comprimento entre quaisquer aresta do quadrado e seu 
            startPoint será as coordenadas do vértice C.
            A___________________________________B         
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            |                                   |
            C‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾D      
            */
        Point startPoint { get; }
        private Random random = new Random();

        public Square(Point startPoint, double sideLength)
        {
            this.startPoint = startPoint;
            this.sideLength = sideLength;
        }

        public Point GetRandomPointInside()
        {
            return new Point(
                random.NextBetween(this.startPoint.x, this.startPoint.x + this.sideLength),
                random.NextBetween(this.startPoint.y,this.startPoint.y + this.sideLength)
            );
        }

        public Double GetArea()
        {
            return this.sideLength * this.sideLength;
        }
    }
}
