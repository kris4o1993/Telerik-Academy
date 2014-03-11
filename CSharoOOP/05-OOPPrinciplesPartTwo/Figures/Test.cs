namespace Figures
{
    using System;
    using System.Collections.Generic;
    class Test
    {
        static void Main()
        {

            List<Shape> figures = new List<Shape>()
            {
                new Rectangle(10, 30),
                new Circle (20),
                new Triangle(10, 10),
                new Circle(26),
                new Rectangle(4, 5),
                new Triangle(5, 2)
            };

            foreach (var shape in figures)
            {
                Console.WriteLine("{0} area is: {1:F2}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
