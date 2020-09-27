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
            for (int i = 0; i < 20; i++)
            {
            Console.WriteLine(Shape.GenerateShape());
            }
            
        }
    }
}
