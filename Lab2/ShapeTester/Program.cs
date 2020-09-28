using Shapes;
using System;
using System.Collections.Generic;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            float totalTriangleCircumference = 0;
            float averageArea = 0;
            float biggestVolume = 0;

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

                if (shape is Shape3D)
                {
                    if ((shape as Shape3D).Volume > biggestVolume)
                    {
                        biggestVolume = (shape as Shape3D).Volume;
                    }
                }
                Console.WriteLine(shape.Area);
                averageArea += shape.Area;
            }

            Console.WriteLine();
            Console.WriteLine($"Total circumference of triangles: {MathF.Round(totalTriangleCircumference, 1)}\nAverage area: {MathF.Round(averageArea / 20, 1)}\nBiggest volume: {biggestVolume}");


        }
    }
}
