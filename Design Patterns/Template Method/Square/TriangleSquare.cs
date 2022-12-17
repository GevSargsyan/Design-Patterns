using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method.Square
{
    internal class TriangleSquare : ShapeSquare
    {
        public double TriangleSide { get; init; }
        public double TriangleHeight { get; init; }

        public TriangleSquare(double TriangleSide,double TriangleHeight)
        {
            this.TriangleSide = TriangleSide;
            this.TriangleHeight = TriangleHeight;
        }
        protected override void CalculateShape()
        {
            Square = 0.5 * TriangleSide * TriangleHeight;
        }

        protected override void Validate()
        {
            IsValid = TriangleSide >= 0 && TriangleHeight >= 0;
        }

        public override string ToString() => "Triangle"; //this
        
    }
}
