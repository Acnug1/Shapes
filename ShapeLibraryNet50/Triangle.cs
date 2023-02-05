using System;

namespace ShapeLibraryNet50
{
    public class Triangle : Shape
    {
        private readonly double[] _sides;

        /// <summary>
        /// Get Triangle Area
        /// </summary>
        /// <param name="a">A side length of a triangle</param>
        /// <param name="b">B side length of a triangle</param>
        /// <param name="c">C side length of a triangle</param>
        public Triangle(double a, double b, double c) : base
            (Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Length of sides should be positive");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("It is not triangle");

            _sides = new double[3] { a, b, c };
        }


        /// <summary>
        /// Triangle is rectangular
        /// </summary>
        /// <returns>True/False</returns>
        public bool IsTriangleRectangular()
        {
            Array.Sort(_sides);
            return Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2);
        }
    }
}
