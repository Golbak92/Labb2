using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public abstract  class Shape3D : Shape
    {
        public abstract float Volume { get; }

        public override Vector3 Center { get; }

        public override float Area { get; }
    }
}
