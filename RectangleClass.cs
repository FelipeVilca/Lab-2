using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace Lab2
{
    public class Rectangle : Shape2D
    {
        public override Vector3 Center { get; }
        public float Width { get; }
        public float Height { get; }
        public override float Circumference => 2 * Width + 2 * Height;
        public override float Area => Width * Height;

        public Rectangle(Vector2 center, Vector2 size)
        {
            // size.X - width; size.Y - height
            Center = new Vector3()
            {
                X = center.X,
                Y = center.Y,
                // There's no Z axis in 2D shapes
                Z = 0
            };

            Width = size.X;
            Height = size.Y;
        }

        // Square
        public Rectangle(Vector2 center, float width)
        {
            Center = new Vector3()
            {
                X = center.X,
                Y = center.Y,
                // There's no Z axis in 2D shapes
                Z = 0
            };

            Width = width;
            Height = width;
        }

        // Returns true if Width and Height are equal
        public bool IsSqare() => Width == Height;

        public override string ToString() => IsSqare() ? $"Square @ ({Center.X:0.00}, {Center.Y:0.00}): w = {Width:0.00}" : $"Rectangle @ ({ Center.X:0.00} ,  { Center.Y:0.00} ): w =  {Width:0.00}";
    }
}
