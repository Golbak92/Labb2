using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public class Triangle : Shape2D
    {
        public Triangle (Vector2 p1, Vector2 p2, Vector2 p3)
        {
        }

        public override string ToString()
        {
            return $"Circle @()";
        }

        public override float Circumference => throw new NotImplementedException();
    }
}
