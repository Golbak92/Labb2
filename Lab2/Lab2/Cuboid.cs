using System;
using System.Numerics;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        private Vector3 size;
        private Vector3 center;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            size.X = width;
            size.Y = width;
            size.Z = width;
        }

        public bool IsCube
        {
            get
            {
                if (size.X == size.Y && size.X == size.Z)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override Vector3 Center 
            {
            get { return center; }
            }

        public override float Area
        {   //Area = 2 × Width × Length + 2 × Length × Height + 2 × Width × Height
            get { return  2 * ((size.X * size.Y) +  (size.Y * size.Z) + (size.X * size.Z)); }
        }

        public override float Volume
        {   //Volume = Length × Width ×  Height
            get { return size.X * size.Y * size.Z; }
        }

        public override string ToString()
        {
            if (size.X != size.Y)
            {
            return $"Cuboid @({center.X}, {center.Y}, {center.Z}): w = {size.X}, h = {size.Y}, l = {size.Z}";
            }
            else
            {
                return $"Cube @({center.X}, {center.Y}, {center.Z}): w = {size.X}, h = {size.Y}, l = {size.Z}";
            }
        }
    }
}
