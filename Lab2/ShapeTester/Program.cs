using System;
using System.Numerics;
using Shapes;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuboid hej = new Cuboid(Vector3.Zero, new Vector3(5f, 5f, 5f));
            Rectangle rect = new Rectangle(Vector3.Zero, 5f);
            Sphere sphere = new Sphere(Vector3.Zero, 5f);

            Console.WriteLine(sphere);
            
        }
    }
}
