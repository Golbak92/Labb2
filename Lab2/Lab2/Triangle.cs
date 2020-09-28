using System;
using System.Numerics;
using System.Runtime.Serialization;

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

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            //Calculation of the length between p1, p2 and p3.
            ac = (float)MathF.Sqrt(MathF.Pow((p1.X - p2.X), 2) + MathF.Pow((p1.Y - p2.Y), 2));
            ba = (float)MathF.Sqrt(MathF.Pow((p1.X - p3.X), 2) + MathF.Pow((p1.Y - p3.Y), 2));
            bc = (float)MathF.Sqrt(MathF.Pow((p3.X - p2.X), 2) + MathF.Pow((p3.Y - p2.Y), 2));
        }

        public override float Circumference
        { // ac + ba + bc (distance between ac, ba and bc)
            get
            {
                return MathF.Round(ac + ba + bc, 1);
            }
        }

        public override float Area
        { // 1/2 * [x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)]
            get
            {
                return MathF.Round(MathF.Sqrt((Circumference / 2) * ((Circumference / 2) - ac) * ((Circumference / 2) - bc) * ((Circumference / 2) - ba)));
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
            return $"Triangle @({Center.X:0.0}, {Center.Y:0.0}): p1({p1.X:0.0}, {p1.Y:0.0}), p2({p2.X:0.0}, {p2.Y:0.0}), p3({p3.X:0.0}, {p3.Y:0.0})";
        }
    }
}
