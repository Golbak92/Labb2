﻿using System;
using System.Numerics;
using Shapes;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle hej = new Rectangle(Vector3.Zero, 5f);

            Console.WriteLine(hej.Circumference);
            
        }
    }
}
