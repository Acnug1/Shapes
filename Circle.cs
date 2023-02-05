using System;

namespace ShapeLibraryNet50
{
    public class Circle : Shape
    {
        /// <summary>
        /// Get Circle Area
        /// </summary>
        /// <param name="radius">Radius</param>
        public Circle(double radius) : base(Math.PI * Math.Pow(radius, 2))
        {
            if (radius <= 0)
                throw new ArgumentException("Radius should be positive");
        }
    }
}
