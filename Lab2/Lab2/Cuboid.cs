using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab2
{
    class Cuboid : Shape3D
    {
        public Cuboid(Vector3 center, Vector3 size)
        {

        }

        public Cuboid(Vector3 center, float width)
        {

        }

        public bool IsCube
        {
            get;
        }
        public override float Volume => throw new NotImplementedException();
    }
}
