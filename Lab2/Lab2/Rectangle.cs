using System.Numerics;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        public Vector2 size
        { get; }

        public override float Circumference
        { get; }

        public override float Area
        { get; }

        public override Vector3 Center
        { get; }

        public bool isSquare
        {
            get { return true; }
        }

        public Rectangle(Vector3 center, Vector2 size)
        {
            Center = new Vector3(new Vector2(center.X, center.Y), 0);
            this.size = size;

            //Area
            new Vector2(size.X * size.Y);

            //Circumference
            new Vector2(2 * (size.X) + 2 * (size.Y));
        }

        public Rectangle(Vector3 center, float width)
        {
            Center = new Vector3(new Vector2(center.X, center.Y), 0);

            //Area
            size = new Vector2((float)width * width);

            //Circumference
            new Vector2(4 * width);
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
