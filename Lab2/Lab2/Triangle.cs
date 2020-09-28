using System;
using System.Collections;
using System.Numerics;

namespace Shapes
{
    public class Triangle : Shape2D, IEnumerable, IEnumerator
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;

        private float ac;
        private float ba;
        private float bc;

        private int position = -1;
        private Vector2[] vectArray = new Vector2[3];

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            vectArray[0] = p1;
            vectArray[1] = p2;
            vectArray[2] = p3;

            //Calculation of the length between p1, p2 and p3.
            ac = MathF.Sqrt(MathF.Pow((p1.X - p2.X), 2) + MathF.Pow((p1.Y - p2.Y), 2));
            ba = MathF.Sqrt(MathF.Pow((p1.X - p3.X), 2) + MathF.Pow((p1.Y - p3.Y), 2));
            bc = MathF.Sqrt(MathF.Pow((p3.X - p2.X), 2) + MathF.Pow((p3.Y - p2.Y), 2));
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
                return MathF.Abs(MathF.Sqrt((Circumference / 2f) * ((Circumference / 2f) - ac) * ((Circumference / 2f) - bc) * ((Circumference / 2f) - ba)));
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

        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public object Current => vectArray[position];

        public bool MoveNext()
        {
            if (position < vectArray.Length - 1)
            {
                position++;
                return true;
            }
            else return false;
        }
        public void Reset()
        {
            position = -1;
        }

    }
}
