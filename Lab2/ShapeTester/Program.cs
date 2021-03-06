﻿using Shapes;
using System;
using System.Collections.Generic;
using System.Numerics;

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
                averageArea += shape.Area;
            }

            Console.WriteLine();
            Console.WriteLine($"Total circumference of triangles: {MathF.Round(totalTriangleCircumference, 1)}\nAverage area: {MathF.Round(averageArea / 20, 1)}\nBiggest volume: {biggestVolume}\n");

            Triangle triangle = new Triangle(new Vector2(1.5f, 2.5f), new Vector2(3.5f, 4.5f), new Vector2(5.5f, 6.5f));

            foreach (var point in triangle)
            {
                Console.WriteLine($"The points for the triangle is {point}.");
            }
        }
    }
}
