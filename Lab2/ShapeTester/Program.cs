using System;
using System.Numerics;
using Shapes;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle hej = new Triangle(new Vector2(5.0f, 8.0f), new Vector2(9.0f, 3.0f), new Vector2(7.0f, 8.0f));

            Console.WriteLine(hej.Area);
            
        }
    }
}
