using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace Lab2
{
    public class Sphere : Shape3D
    {
        public override Vector3 Center { get; }
        public float Radius { get; }
        public override float Volume => 4 * ((float)Math.PI) * Radius * Radius * Radius / 3f;
        public override float Area => 4 * ((float)Math.PI) * Radius * Radius;

        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString() => $"Sphere @ ({Center.X:0.00}, {Center.Y:0.00}): r = {Radius:0.00}";
    }
}
