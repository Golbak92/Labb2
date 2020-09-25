using System.Numerics;
using System;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private Vector3 center;
        private Vector2 size;
        private float width;
        //public Vector2 size
        //{ get; }

        //public override float Circumference
        //{ get; }

        //public override float Area
        //{ get; }

        //public override Vector3 Center
        //{ get; }

        public bool isSquare
        {
            get 
            {
                if (size.X == size.Y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Rectangle(Vector3 center, Vector2 size)
        {
            this.size = size;
            this.center = center;

            ////Area
            //new Vector2(size.X * size.Y);

            ////Circumference
            //new Vector2(2 * (size.X) + 2 * (size.Y));
        }


        public Rectangle(Vector3 center, float width)
        {
            this.center = center;
            this.width = width;
            size.X = width;
            size.Y = width;

            ////Area
            //size = new Vector2((float)width * width);

            ////Circumference
            //new Vector2(4 * width);
        }


        public override float Circumference
        { // Square: 4 * x, Rectangle: 2 * (width) + 2 * (height)
            get
            {
                if (isSquare == true)
                {
                    return 4 * width;
                }
                else
                {
                    return 2 * (size.X) + 2 * (size.Y);
                }
                
            }
        }

        public override float Area
        { // width * height;
            get
            {
                return size.X * size.Y;
            } 
        }

        public override Vector3 Center
        {  //Midpoint: x = width1 + height1 / 2, y = width2 + height2 / 2
            get
            {
                return new Vector3(center.X = size.X / 2, center.Y = size.Y / 2, 0);
            }
        }


        public override string ToString()
        {
            if (size.X == size.Y)
            {
                return $"Square @({Center.X}, {Center.Y}): w = {size.X}, h = {size.Y}";
            }
            else
            {
                return $"Rectangle @({Center.X}, {Center.Y}): w = {size.X}, h = {size.Y}";
            }
        }
    }
}
