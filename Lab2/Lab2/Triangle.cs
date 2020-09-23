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
        private Vector2 mid;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 mid)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.mid = mid;
        }

        public override float Area
        { //Area = 1/2 * [x1(y2 - y3) + x2(y3 - y1) + x3(y1 - y2)]
            get 
            { 
                return 1 / 2 * (p1.X *(p2.Y - p3.Y) + p2.X*(p3.Y - p1.Y) + p3.X*(p1.Y - p2.Y)); 
            }
        }

        public override Vector2 Center
        { // Midpoint = (x1 + x2 + x3 / 2, y1 + y2 + y3 / 2)
            get 
            { 
                new Vector2(p1.X + p2.X + p3.X / 2, p1.Y + p2.Y + p3.Y / 2); 
                return mid; 
            } 
        }

        public override string ToString()
        {
            return $"Triangle @({mid.X}, {mid.Y}): p1({p1.X}, {p1.Y}), p2({p2.X}, {p2.Y}), p3({p3.X}, {p3.Y})";
        }

        public override float Circumference => throw new NotImplementedException();
    }
}
