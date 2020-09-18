using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab2
{
    abstract class Shape2D : Shape
    {
        public override Vector3 Center => throw new NotImplementedException();

        public override float Area => throw new NotImplementedException();

        public abstract float Circumference 
        { get; }
    }
}
