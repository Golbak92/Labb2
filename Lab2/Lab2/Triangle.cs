using System;
using System.Numerics;

namespace Shapes
{
    public class Triangle : Shape2D
    {
        public Vector2 p1;
        public Vector2 p2;
        public Vector2 p3;
        public float ac;
        public float ba;
        public float bc;


        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            ac = (float)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
            ba = (float)Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2));
            bc = (float)Math.Sqrt(Math.Pow((p3.X - p2.X), 2) + Math.Pow((p3.Y - p2.Y), 2));

        }

        public override float Circumference
        { //Circumference = ac + ba + bc (distance between ac, ba and bc)
            get
            {
                return ac + ba + bc;
            }
        }

        public override float Area
        { //Area = 1/2 * [x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)]
            get
            {
                return 1 / 2 * (p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y));
            }

        }

        public override Vector3 Center
        {
            // (x1 + x2 + x3 / 2, y1 + y2 + y3 / 2)
            get
            {
                return new Vector3((p1.X + p2.X + p3.X) / 2, (p1.Y + p2.Y + p3.Y) / 2, 0);
            }
        }

        public override string ToString()
        {
            return $"Triangle @({Center.X}, {Center.Y}): p1({p1.X}, {p1.Y}), p2({p2.X}, {p2.Y}), p3({p3.X}, {p3.Y})";
        }
    }
}
