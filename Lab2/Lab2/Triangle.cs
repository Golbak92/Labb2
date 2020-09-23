using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Shapes
{
    public class Triangle : Shape2D
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public override float Area
        { //Area = 1/2 * [x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)]
            get { return 1 / 2 * (p1.X *(p2.Y - p3.Y) + p2.X*(p3.Y - p1.Y) + p3.X*(p1.Y - p2.Y)); }
        }

        public override Vector2 Center
        {
            // (x1 + x2 + x3 / 2, y1 + y2 + y3 / 2)
            get {
                return new Vector2(p1.X + p2.X + p3.X / 2, p1.Y + p2.Y + p3.Y / 2);
                } 
        }

        public override string ToString()
        {
            return $"Triangle @(3.0, 1.0): p1({p1.X}, {p1.Y}), p2({p2.X}, {p2.Y}), p3({p3.X}, {p3.Y})";
        }

        public override float Circumference => throw new NotImplementedException();
    }
}
