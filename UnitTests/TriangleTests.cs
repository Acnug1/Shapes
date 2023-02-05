using System;
using NUnit.Framework;
using ShapeLibraryNet50;

namespace UnitTests
{
    public class TriangleTests
    {
        private Triangle _triangle;

        /// <summary>
        /// One or more sides of Triangle is zero
        /// Should throw away ArgumentException!
        /// </summary>
        [Test]
        public void SideIsZero()
        {
            Assert.Throws<ArgumentException>(() => _triangle = new(6.0, 0.0, 4.0));
        }

        /// <summary>
        /// One or more sides of Triangle is less than zero
        /// Should throw away ArgumentException!
        /// </summary>
        [Test]
        public void SideIsLessThanZero()
        {
            Assert.Throws<ArgumentException>(() => _triangle = new(6.0, 10.0, -4.0));
        }

        /// <summary>
        /// The triangle does not exist
        /// Should throw away ArgumentException!
        /// </summary>
        [Test]
        public void TriangleNotExist()
        {
            Assert.Throws<ArgumentException>(() => _triangle = new(25, 10, 5));
        }

        /// <summary>
        /// Checking the calculation of the area of the triangle with accuracy
        /// </summary>
        [Test]
        public void TriangleAreaDeltaCompute()
        {
            _triangle = new(40, 35, 25);
            Assert.AreEqual(433.0127018922, _triangle.Area, Math.E, "Result out of range!");
        }

        /// <summary>
        /// Checking for the squareness of the triangle
        /// This triangle is rectangular
        /// </summary>
        [Test]
        public void TriangleIsRectangular()
        {
            _triangle = new(17, 145, 144);
            Assert.IsTrue(_triangle.IsTriangleRectangular());
        }

        /// <summary>
        /// Checking for the squareness of the triangle
        /// This triangle is not rectangular
        /// </summary>
        [Test]
        public void TriangleIsNotRectangular()
        {
            _triangle = new(17, 144, 145.04);
            Assert.IsFalse(_triangle.IsTriangleRectangular());
        }
    }
}
