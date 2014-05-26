namespace Figures
{
    using System;
    class Circle : Shape
    {

        public Circle(double diameter)
            : base(diameter, diameter)
        {

        }
       
        public override double CalculateSurface()
        {
            double radius = this.Width / 2;
            return Math.PI * radius * radius;
        }

    }
}
