using System;
using System.Collections;
using Template_Method.Square;

namespace Template_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleSquare triangle = new (5, 10);
            CircleSquare circle = new(10);

            ISquare[] shapes = new ISquare[] { triangle, circle };

            DisplaySquare(shapes);
            Console.ReadKey();
        }

        private static void DisplaySquare(ISquare[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Calculate();
            }
        }
    }
}
