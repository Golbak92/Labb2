using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public class Circle : Shape2D
    {
        public Vector3 center;
        public float radius;

        public Circle(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override Vector3 Center
        {
            get
            {
                return center;
            }
        }
        public override float Area
        {  //Area for Circle
            get
            { return (float)Math.PI * (radius * radius);}
        }

        public override float Circumference
        {  //Circumference for Circle
            get
            { return (float)Math.PI * (radius * 2); }
        }

        public override string ToString()
        {
            return $"Circle @({center.X}, {center.Y}): r = {radius}";
        }
    }
}
