using System.Numerics;
using System;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private Vector3 center;
        private Vector2 size;
        private float width;

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
            //this.size = size;
            this.center = center;
            this.size.X = (float)Math.Round(size.X, 1);
            this.size.Y = (float)Math.Round(size.Y, 1);
        }

        public Rectangle(Vector3 center, float width)
        {
            this.center = center;
            this.width = width;
            size.X = (float)Math.Round(width, 1);
            size.Y = size.X;
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
                return (float)Math.Round(size.X * size.Y, 1);
            } 
        }

        public override Vector3 Center
        { 
            get
            {
                return center;
            }
        }

        public override string ToString()
        {
            if (size.X == size.Y)
            {
                return $"Square @({Center.X:0.0}, {Center.Y:0.0}): w = {size.X:0.0}, h = {size.Y:0.0}";
            }
            else
            {
                return $"Rectangle @({Center.X:0.0}, {Center.Y:0.0}): w = {size.X:0.0}, h = {size.Y:0.0}";
            }
        }
    }
}
