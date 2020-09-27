using System;
using System.Collections.Generic;
using System.Numerics;


namespace Shapes
{
    public abstract class Shape
    {
        private static Random rndNumber = new Random();
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        public static Shape GenerateShape()
        {
            Vector3 vector3Random = new Vector3((float)rndNumber.NextDouble() * 10, (float)rndNumber.NextDouble() * 10, (float)rndNumber.NextDouble() * 10);
            float floatRandom = (float)rndNumber.NextDouble();
            
                switch (rndNumber.Next(0, 7))
                {
                    case 0: // Rectangle
                        return new Rectangle(new Vector3(VectorTwoRandom(), 0), VectorTwoRandom());

                    case 1: // Square
                        return new Rectangle(new Vector3(VectorTwoRandom(), 0), floatRandom);

                    case 2: // Cuboid
                        return new Cuboid(new Vector3(VectorTwoRandom(), 0), vector3Random);

                    case 3: // Cube
                        return new Cuboid(new Vector3(VectorTwoRandom(), 0), floatRandom);

                    case 4: // Triangle
                    return RandomTriangle(VectorTwoRandom(), VectorTwoRandom());

                    case 5: // Circle
                        return new Circle(new Vector3(VectorTwoRandom(), 0), floatRandom);

                    case 6: // Sphere
                        return new Sphere(new Vector3(VectorTwoRandom(), 0), floatRandom);

                    default:
                        return null;
                }           
        }

        public static void GenerateShape(Vector3 midpoint)
        {

        }

        private static Vector2 VectorTwoRandom()
        {
            return new Vector2((float)rndNumber.NextDouble() * 10, (float)rndNumber.NextDouble() * 10);
        }

        private static Triangle RandomTriangle(Vector2 p1, Vector2 p2) //Method to calculate the last point in a triangle and to return a random triangle.
        {   
            Vector2 center = VectorTwoRandom();
            float p3X = center.X * 3 - p1.X - p2.X;
            float p3Y = center.Y * 3 - p1.Y - p2.Y;
            Vector2 p3 = new Vector2(p3X, p3Y);
            return new Triangle(p1, p2, p3);
        }
    }
}
