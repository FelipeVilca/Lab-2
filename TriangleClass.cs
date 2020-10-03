using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace Lab2
{
    public class Triangle : Shape2D
    {
        public Vector2 P1 { get; }
        public Vector2 P2 { get; }
        public Vector2 P3 { get; }
        public override Vector3 Center { get; }
        public override float Circumference { get; }
        public override float Area { get; }

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;

            //Center
            Center = new Vector3()
            {
                X = (P1.X + P2.X + P3.X) / 3f,
                Y = (P1.Y + P2.Y + P3.Y) / 3f,
                // There's no Z axis in 2D shapes
                Z = 0
            };

            // Sides - each side is the length between two of three points of the triangle
            float s1 = (float)Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y));
            float s2 = (float)Math.Sqrt((P3.X - P2.X) * (P3.X - P2.X) + (P3.Y - P2.Y) * (P3.Y - P2.Y));
            float s3 = (float)Math.Sqrt((P1.X - P3.X) * (P1.X - P3.X) + (P1.Y - P3.Y) * (P1.Y - P3.Y));

            // Circumference and Area
            Circumference = s1 + s2 + s3;

            var p = Circumference / 2f;
            Area = (float)Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
        }

        public override string ToString() => $"Triangle @ ({Center.X:0.00}, {Center.Y:0.00}): P1 ({P1.X:0.00}, {P1.Y:0.00}), P2 ({P2.X:0.00}, {P2.Y:0.00}), P3 ({P3.X:0.00}, {P3.Y:0.00})";
    }
}
