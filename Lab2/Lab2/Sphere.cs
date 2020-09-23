using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab2
{
    class Sphere : Shape3D
    {
        public Sphere(Vector3 center, float radius)
        {

        }

        public override float Volume => throw new NotImplementedException();

        public override string ToString()
        {
            return "Sphere @(0.0, 1.0, 0.0): r = 3.2";
        }
    }
}
