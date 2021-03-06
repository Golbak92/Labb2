﻿using System;
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
                return MathF.PI * MathF.Pow(radius, 2f);
            }
        }

        public override float Circumference
        {  // π * d == π * 2r
            get
            { 
                return MathF.PI * (radius * 2f);
            }
        }

        public override string ToString()
        {
            return $"Circle @({center.X:0.0}, {center.Y:0.0}): r = {radius:0.0}";
        }
    }
}
