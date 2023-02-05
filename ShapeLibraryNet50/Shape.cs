using System;

namespace ShapeLibraryNet50
{
    public abstract class Shape
    {
        private readonly double _area;

        protected Shape(double area) => _area = area;
        
        public double Area => _area;

        /// <summary>
        /// Print name and area of shape
        /// </summary>
        public void PrintAreaOfShape()
        {
            Console.WriteLine($"Type of shape: {this.GetType().Name}, area = {_area:F2}");
        }
    }
}
