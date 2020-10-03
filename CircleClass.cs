using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace Lab2
{
    public class Circle : Shape2D
    {
        public override Vector3 Center { get; }
        public float Radius { get; }
        public override float Circumference => 2f * ((float)Math.PI) * Radius;
        public override float Area => ((float)Math.PI) * Radius * Radius;

        public Circle(Vector2 center, float radius)
        {
            Center = new Vector3()
            {
                X = center.X,
                Y = center.Y,
                // There's no Z axis in 2D shapes
                Z = 0
            };
            Radius = radius;
        }

        public override string ToString() => $"Circle @ ({Center.X:0.00}, {Center.Y:0.00}): r = {Radius:0.00}";
    }
}
