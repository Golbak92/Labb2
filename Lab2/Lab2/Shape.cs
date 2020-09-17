using System;
using System.Numerics;

namespace Lab2
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }
}
