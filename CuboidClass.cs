using System.Numerics;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab2
{
    public class Cuboid : Shape3D
    {
        public float Width { get; }
        public float Height { get; }
        public float Depth { get; }
        public override Vector3 Center { get; }
        public override float Volume => Width * Height * Depth;
        public override float Area => 2 * (Width * Height + Height * Depth + Width * Depth);

        public Cuboid(Vector3 center, Vector3 size)
        {
            Center = center;

            // size.X - width; size.Y - height; size.Z - depth
            Width = size.X;
            Height = size.Y;
            Depth = size.Z;
        }

        // Cube
        public Cuboid(Vector3 center, float width)
        {
            Center = center;
            Width = width;
            Height = width;
            Depth = width;
        }

        // Returns true if Width, Height and Depth are equal
        public bool IsCube() => Width == Height && Height == Depth;

        public override string ToString() => IsCube() ? $"Cube @ ({Center.X:0.00}, {Center.Y:0.00}, {Center.Z:0.00}): w = {Width:0.00}" : $"Cuboid @ ({Center.X:0.00}, {Center.Y:0.00}, {Center.Z:0.00}): w = {Width:0.00}, h = {Height:0.00}, l = {Depth:0.00}";
    }
}
