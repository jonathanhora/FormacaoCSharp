using System;
using Figuras.Entities.Enums;

namespace Figuras.Entities
{
    class Circle : Shape
    {
        public Double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
