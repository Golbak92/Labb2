using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 center;
        private Vector2 radius;

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.radius = size;
        }

        public override float Circumference => throw new NotImplementedException();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
