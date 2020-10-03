using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace Lab2
{
	public abstract class Shape
	{
		public abstract Vector3 Center { get; }
		public abstract float Area { get; }

		// We need this in the class, because if we create the Random instance inside GenerateShape(), we will be getting the same values over and over again
		// That is due to the base seed which uses system clock, and if we create them too often, we will end up with the same values and shapes
		private static Random RNG = new Random();

		// This is modifiable - by default NextDouble() * 50, which means the number will be a float between 0 and 50 (otherwise we'll get really big numbers)
		private static float GetRandomValue() => (float)RNG.NextDouble() * 50;

		// Returns a fully randomized shape
		public static Shape GenerateShape()
		{
			// Returned shape
			Shape shape = null;

			var num = RNG.Next(0, 7);

			switch (num)
			{
				case 0: // Circle
					{
						var radius = GetRandomValue();
						var cen = new Vector2()
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};

						shape = new Circle(cen, radius);

						break;
					}
				case 1: // Rectangle
					{
						var size = new Vector2()
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};
						var cen = new Vector2()
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};

						shape = new Rectangle(cen, size);

						break;
					}
				case 2: // Square
					{
						var width = GetRandomValue();
						var cen = new Vector2()
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};

						shape = new Rectangle(cen, width);

						break;
					}
				case 3: // Triangle
					{
						var p1 = new Vector2
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};
						var p2 = new Vector2
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};
						var p3 = new Vector2
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};

						shape = new Triangle(p1, p2, p3);

						break;
					}
				case 4: //Cuboid
					{
						var size = new Vector3()
						{
							X = GetRandomValue(),
							Y = GetRandomValue(),
							Z = GetRandomValue()
						};
						var cen = new Vector3()
						{
							X = GetRandomValue(),
							Y = GetRandomValue(),
							Z = GetRandomValue()
						};

						shape = new Cuboid(cen, size);

						break;
					}
				case 5: // Cube
					{
						var width = GetRandomValue();
						var cen = new Vector3()
						{
							X = GetRandomValue(),
							Y = GetRandomValue(),
							Z = GetRandomValue()
						};

						shape = new Cuboid(cen, width);

						break;
					}
				case 6: // Sphere
					{
						var radius = GetRandomValue();
						var cen = new Vector3()
						{
							X = GetRandomValue(),
							Y = GetRandomValue(),
							Z = GetRandomValue()
						};

						shape = new Sphere(cen, radius);

						break;
					}
			}

			return shape;
		}

		// Returns a partially randomized shape
		public static Shape GenerateShape(Vector3 center)
		{
			// Returned shape
			Shape shape = null;

			var num = RNG.Next(0, 7);

			switch (num)
			{
				case 0: // Circle
					{
						var radius = GetRandomValue();
						var ctr = new Vector2()
						{
							X = center.X,
							Y = center.Y
						};

						shape = new Circle(ctr, radius);

						break;
					}
				case 1: // Rectangle
					{
						var size = new Vector2()
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};
						var ctr = new Vector2()
						{
							X = center.X,
							Y = center.Y
						};

						shape = new Rectangle(ctr, size);

						break;
					}
				case 2: // Square
					{
						var width = GetRandomValue();
						var ctr = new Vector2()
						{
							X = center.X,
							Y = center.Y
						};

						shape = new Rectangle(ctr, width);

						break;
					}
				case 3: // Triangle
					{
						var p1 = new Vector2
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};
						var p2 = new Vector2
						{
							X = GetRandomValue(),
							Y = GetRandomValue()
						};

						// Calculate 3rd point, so that center will be what was given as parameter
						// Center.X = (P1.X + P2.X + P3.X) / 3f => P3.X = 3f * Center.X - P1.X - P2.X
						var p3 = new Vector2()
						{
							X = 3 * center.X - p1.X - p2.X,
							Y = 3 * center.Y - p1.Y - p2.Y
						};

						shape = new Triangle(p1, p2, p3);

						break;
					}
				case 4: // Cuboid
					{
						var size = new Vector3()
						{
							X = GetRandomValue(),
							Y = GetRandomValue(),
							Z = GetRandomValue()
						};

						shape = new Cuboid(center, size);

						break;
					}
				case 5: // Cube
					{
						var width = GetRandomValue();

						shape = new Cuboid(center, width);

						break;
					}
				case 6: // Sphere
					{
						var radius = GetRandomValue();

						shape = new Sphere(center, radius);

						break;
					}
			}

			return shape;
		}
	}
}
