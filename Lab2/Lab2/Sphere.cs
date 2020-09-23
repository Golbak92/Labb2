using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        private float radius;
        private Vector3 center;

        public Sphere(Vector3 center, float radius)
        {
            this.radius = radius;
            this.center = center;
        }

        public override float Volume
        {
            // V=4/3πr3
            get { return (float)((4 / 3) * Math.PI * Math.Pow(radius, 3)); }

        }

        public override string ToString()
        {
            return $"Sphere @(0.0, 1.0, 0.0): r = {radius}";
        }
    }
}
