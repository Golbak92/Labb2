using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public class Circle : Shape2D
    {
        private Vector3 center;
        private float radius;

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
        {  // π * r^2
            get
            { 
                return (float)(MathF.PI * (MathF.Pow((radius), 2)));
            }
        }

        public override float Circumference
        {  // π * d == π * 2r
            get
            { 
                return (float)MathF.PI * (radius * 2);
            }
        }

        public override string ToString()
        {
            return $"Circle @({center.X:0.0}, {center.Y:0.0}): r = {radius:0.0}";
        }
    }
}
