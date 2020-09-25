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

        public override Vector3 Center
        {
            get { return center; }
        }
        public override float Area
        {   //A=4πr2
            get { return 4 * MathF.PI * MathF.Pow(radius, 2); }
        }

        public override float Volume
        {
            // V=4/3πr3
            get { return 4.0f / 3.0f * MathF.PI * MathF.Pow(radius, 3); }

        }

        public override string ToString()
        {
            return $"Sphere @({center.X}, {center.Y}, {center.Z}): r = {radius}";
        }
    }
}
