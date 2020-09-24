using System;
using System.Numerics;
using Shapes;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle hej = new Triangle(new Vector2(5f, 8f), new Vector2(9f, 3f), new Vector2(7f, 8f));

            Console.WriteLine(hej.Area);
            
        }
    }
}
