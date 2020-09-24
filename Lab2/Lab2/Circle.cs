using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Shapes
{
    public class Circle : Shape2D
    {
        private Vector3 center;
        private float radius;

        public override float Circumference
        { get; }

        public override float Area
        { get; }

        public override Vector3 Center
        { get; }

        public Circle(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;

            //Circumferene - π * d = π * 2r
            Circumference = (float)Math.PI * (radius * 2);

            //Area - π * r^2
            Area = (float)(Math.PI*(Math.Pow((radius), 2)));

            Center = new Vector3(new Vector2(center.X, center.Y), 0);
        }

        //public override Vector3 Center
        //{
        //    get
        //    {
        //        return center;
        //    }
        //}
        //public override float Area
        //{  //Area
        //    get
        //    { return (float)Math.PI * (radius * radius);}
        //}

        //public override float Circumference
        //{  //Circumference
        //    get
        //    { return (float)Math.PI * (radius * 2); }
        //}

        public override string ToString()
        {
            return $"Circle @({center.X}, {center.Y}): r = {radius}";
        }
    }
}
