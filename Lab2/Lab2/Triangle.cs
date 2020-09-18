using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    abstract class Triangle : Shape2D
    {
        public float p1;
        public float p2;
        public float p3;

        public Triangle (float aP1, float aP2, float aP3)
        {
            p1 = aP1;
            p2 = aP2;
            p3 = aP3;
        }
    }
}
