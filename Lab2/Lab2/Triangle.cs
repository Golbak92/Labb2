using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab2
{
    public class Triangle : Shape2D
    {
        public Triangle (Vector2 p1, Vector2 p2, Vector2 p3)
        {
        }

        public override string ToString()
        {
            return $"Circle @({p1})";
        }

        public override float Circumference => throw new NotImplementedException();
    }
}
