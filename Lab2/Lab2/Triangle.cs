using System;
using System.Numerics;

namespace Shapes
{
    public class Triangle : Shape2D
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private float ac;
        private float ba;
        private float bc;

        //public override float Circumference
        //{ get; }

        //public override float Area
        //{ get; }

        //public override Vector3 Center
        //{ get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            //Calculation of the length between p1, p2 and p3.
            ac = (float)Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
            ba = (float)Math.Sqrt(Math.Pow((p1.X - p3.X), 2) + Math.Pow((p1.Y - p3.Y), 2));
            bc = (float)Math.Sqrt(Math.Pow((p3.X - p2.X), 2) + Math.Pow((p3.Y - p2.Y), 2));

            ////Circumference - ac + ba + bc (distance between ac, ba and bc)
            //Circumference = ac + ba + bc;

            ////Area - square root of s(s − a) (s − b) (s − c)
            ////s = ac + ba + bc / 2
            //Area = (float)Math.Sqrt((Circumference / 2) * ((Circumference / 2) - ac) * ((Circumference / 2) - bc) * ((Circumference / 2) - ba));

            ////Midpoint - (x1 + x2 + x3 / 3, y1 + y2 + y3 / 3)
            //Center = new Vector3((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3, 0);
        }

        public override float Circumference
        { // ac + ba + bc (distance between ac, ba and bc)
            get
            {
                return ac + ba + bc;
            }
        }

        public override float Area
        { // 1/2 * [x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)]
            get
            {
                return (float)Math.Round(Math.Sqrt((Circumference / 2) * ((Circumference / 2) - ac) * ((Circumference / 2) - bc) * ((Circumference / 2) - ba)));
            }

        }

        public override Vector3 Center
        { // (x1 + x2 + x3 / 3, y1 + y2 + y3 / 3)
            get
            {
                return new Vector3((p1.X + p2.X + p3.X) / 3, (p1.Y + p2.Y + p3.Y) / 3, 0);
            }
        }

        public override string ToString()
        {
            return $"Triangle @({Center.X}, {Center.Y}): p1({p1.X}, {p1.Y}), p2({p2.X}, {p2.Y}), p3({p3.X}, {p3.Y})";
        }
    }
}
