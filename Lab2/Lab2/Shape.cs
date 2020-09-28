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
                switch (rndNumber.Next(0, 7))
                {
                    case 0: // Rectangle
                        return new Rectangle(new Vector3(VectorTwoRandom(), 0), VectorTwoRandom());

                    case 1: // Square
                        return new Rectangle(new Vector3(VectorTwoRandom(), 0), FloatRandom());

                    case 2: // Cuboid
                        return new Cuboid(VectorThreeRandom(), VectorThreeRandom());

                    case 3: // Cube
                        return new Cuboid(VectorThreeRandom(), FloatRandom());

                    case 4: // Triangle
                    return RandomTriangle(VectorTwoRandom(), VectorTwoRandom());

                    case 5: // Circle
                        return new Circle(new Vector3(VectorTwoRandom(), 0), FloatRandom());

                    case 6: // Sphere
                        return new Sphere(VectorThreeRandom(), FloatRandom());

                    default:
                        return null;
                }           
        }


        public static Shape GenerateShape(Vector3 center)
        {
            switch (rndNumber.Next(0, 7))
            {
                case 0: // Rectangle;
                    return new Rectangle(center, VectorTwoRandom());

                case 1: // Square
                    return new Rectangle(center, FloatRandom());

                case 2: // Cuboid
                    return new Cuboid(center, VectorThreeRandom());

                case 3: // Cube
                    return new Cuboid(center, FloatRandom());

                case 4: // Triangle
                    return RandomTriangle(center, VectorTwoRandom(), VectorTwoRandom());

                case 5: // Circle
                    return new Circle(center, FloatRandom());

                case 6: // Sphere
                    return new Sphere(center, FloatRandom());

                default:
                    return null;
            }
        }

        private static Vector2 VectorTwoRandom()
        {
            return new Vector2((float)rndNumber.NextDouble() * 10, (float)rndNumber.NextDouble() * 10);
        }

        private static Vector3 VectorThreeRandom()
        {
            return new Vector3((float)rndNumber.NextDouble() * 10, (float)rndNumber.NextDouble() * 10, (float)rndNumber.NextDouble() * 10);
        }

        private static float FloatRandom()
        {
            return (float)rndNumber.NextDouble();
        }

        private static Triangle RandomTriangle(Vector2 p1, Vector2 p2) //Method to calculate the last point in a triangle and to return a random triangle.
        {   
            Vector2 center = VectorTwoRandom();
            float p3X = center.X * 3 - p1.X - p2.X;
            float p3Y = center.Y * 3 - p1.Y - p2.Y;
            Vector2 p3 = new Vector2(p3X, p3Y);
            return new Triangle(p1, p2, p3);
        }

        private static Triangle RandomTriangle(Vector3 vect3Center, Vector2 p1, Vector2 p2) //Overload with a set center.
        {
            Vector2 center;
            center.X = vect3Center.X;
            center.Y = vect3Center.Y;
            float p3X = center.X * 3 - p1.X - p2.X;
            float p3Y = center.Y * 3 - p1.Y - p2.Y;
            Vector2 p3 = new Vector2(p3X, p3Y);
            return new Triangle(p1, p2, p3);
        }
    }
}
