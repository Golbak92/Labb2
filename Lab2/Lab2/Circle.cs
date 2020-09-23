using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab2
{
    public class Circle : Shape2D
    {
        private Vector2 center;
        private float radius;

        public Circle(Vector2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }


        public override float Area
        {  //Area for Circle
            get
            { return (float)Math.PI * (radius * radius);}
        }

        public override float Circumference
        {  //Omkrets for Circle
            get
            { return (float)Math.PI * (radius * 2); }
        }

        public override string ToString()
        {
            return $"Circle @({center.X}, {center.Y}): r = {radius}";
        }
    }
}
