using System;
using System.Numerics;
using Shapes;
namespace ShapeTester
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuboid cuboid = new Cuboid(Vector3.Zero, new Vector3(8f, 6f, 5f));

            Console.WriteLine(cuboid.Area);
            
        }
    }
}
