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

        public Triangle (Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public static float Distance (Vector2 p1, Vector2 p2, Vector2 p3)
        {
        
        }

        public override string ToString()
        {
            return $"Circle @()";
        }

        public override float Circumference => throw new NotImplementedException();
    }
}
