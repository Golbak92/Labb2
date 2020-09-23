using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab2
{
    class Triangle : Shape2D
    {
        public override float Circumference => throw new NotImplementedException();

        public Vector2 p1;
        public Vector2 p2;
        public Vector2 p3;

        public Triangle (Vector2 aP1, Vector2 aP2, Vector2 aP3)
        {
        }  

        
    }
}
