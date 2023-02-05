using System;
using ShapeLibraryNet50;

namespace Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new(5.0);
            circle.PrintAreaOfShape();

            Triangle triangle = new(60, 91, 109);
            triangle.PrintAreaOfShape();
            Console.WriteLine($"Triangle is rectangular - {triangle.IsTriangleRectangular()}");

            Console.ReadKey();
        }
    }
}
