using System;
using System.Numerics;

namespace Shapes
{
    public class Sphere : Shape3D
    {
        private float radius;
        private Vector3 center;

        public Sphere(Vector3 center, float radius)
        {
            this.radius = MathF.Round(radius);
            this.center = center;
        }

        public override Vector3 Center
        {
            get { return center; }
        }
        public override float Area
        {   //A=4πr2
            get { return MathF.Round(4 * MathF.PI * MathF.Pow(radius, 2), 1); }
        }

        public override float Volume
        {
            // V=4/3πr3
            get { return MathF.Round(4.0f / 3.0f * MathF.PI * MathF.Pow(radius, 3), 1); }

        }

        public override string ToString()
        {
            return $"Sphere @({center.X:0.0}, {center.Y:0.0}, {center.Z:0.0}): r = {radius:0.0}";
        }
    }
}
