using System;
using System.Collections.Generic;
using System.Numerics;
using Shapes;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            float totalTriangleCircumference = 0;
            float averageArea = 0;

            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);

                if (shape is Triangle)
                {
                    totalTriangleCircumference += (shape as Triangle).Circumference;
                }

                if (shape is Cuboid |)
                {

                }
                averageArea += MathF.Round(shape.Area, 1);
                Console.WriteLine(MathF.Round(shape.Area, 1));
            }
                Console.WriteLine($"Average area: {MathF.Round(averageArea / 20, 1)}");

        }
    }
}
