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
            this.size = size;
            this.center = center;
        }

        public Rectangle(Vector3 center, float width)
        {
            this.center = center;
            this.width = width;
            size.X = width;
            size.Y = width;
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
                return $"Square @({Center.X}, {Center.Y}): w = {size.X}, h = {size.Y}";
            }
            else
            {
                return $"Rectangle @({Center.X}, {Center.Y}): w = {size.X}, h = {size.Y}";
            }
        }
    }
}
