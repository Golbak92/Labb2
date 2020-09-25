using System;
using System.Collections.Generic;
using System.Numerics;


namespace Shapes
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
        public static Shape GenerateShape()
        {
            Random rndNumber = new Random();
            Vector3 vector3Random = new Vector3((float)rndNumber.NextDouble(), (float)rndNumber.NextDouble(), (float)rndNumber.NextDouble());
            Vector2 vector2Random = new Vector2((float)rndNumber.NextDouble(), (float)rndNumber.NextDouble());
            float floatRandom = (float)rndNumber.NextDouble();
            
                switch (rndNumber.Next(0, 7))
                {
                    case 0: // Rectangle
                        return new Rectangle(new Vector3(vector2Random, 0), vector2Random);

                    case 1: // Square
                        return new Rectangle(new Vector3(vector2Random, 0), floatRandom);

                    case 2: // Cuboid
                        return new Cuboid(new Vector3(vector2Random, 0), vector3Random);

                    case 3: // Cube
                        return new Cuboid(new Vector3(vector2Random, 0), floatRandom);

                    case 4: // Triangle
                        return new Triangle(vector2Random, vector2Random, vector2Random);

                    case 5: // Circle
                        return new Circle(new Vector3(vector2Random, 0), floatRandom);

                    case 6: // Sphere
                        return new Sphere(new Vector3(vector2Random, 0), floatRandom);

                    default:
                        return null;
                }           
        }

        public static void GenerateShape(Vector3 midpoint)
        {

        }
    }
}
