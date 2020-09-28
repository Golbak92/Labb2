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

            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            for (int i = 0; i < 20; i++)
            {
            Console.WriteLine(Shape.GenerateShape(new Vector3(1.5f, 2.5f, 3.5f))); 
            }

        }
    }
}
