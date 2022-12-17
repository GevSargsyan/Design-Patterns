using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method.Square
{
    internal abstract class ShapeSquare : ISquare
    {
        public double Square { get; protected set; }
        public bool IsValid { get; protected set; }
        public void Calculate()
        {
            Validate();

            if (IsValid)
            {
                CalculateShape();
                OutputResult();
            }
        }

        protected abstract void Validate();
        protected abstract void CalculateShape();

        protected virtual void OutputResult()
        {
            Console.WriteLine($"{this} - Square: {Square}");
        }
    }
}
