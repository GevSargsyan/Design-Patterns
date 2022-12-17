using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method.Square
{
    internal class CircleSquare : ShapeSquare
    {
        public double Radius { get; init; }
        public CircleSquare(double Radius)
        {
            this.Radius = Radius;
        }
        protected override void CalculateShape()
        {
            Square = Math.PI * Radius * Radius;  
        }
        protected override void Validate()
        {
            IsValid = Radius >= 0;
        }
        public override string ToString() => "Circle";

    }
}
