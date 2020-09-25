using System;
using System.Numerics;
using System.Collections.Generic;


namespace Shapes
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static void GenerateShape()
        {
            List<Shape> shapes = new List<Shape>(20);
            Random rndNumber = new Random();
            int rndShape = rndNumber.Next(0, 6);

            for (int i = 0; i < 20; i++)
            {
                switch (rndShape)
                {
                    case 0:
                        shapes.Add(new Rectangle());
                        break;

                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    default:
                        break;
                }
            }
        }

        public static void GenerateShape(Vector3 midpoint)
        {

        }
    }
}
