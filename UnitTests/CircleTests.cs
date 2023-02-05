using System;
using NUnit.Framework;
using ShapeLibraryNet50;

namespace UnitTests
{
    public class CircleTests
    {
        private Circle _circle;

        /// <summary>
        /// Check for ArgumentException (The radius of the circle is zero)
        /// Should throw away ArgumentException!
        /// </summary>
        [Test]
        public void CircleRadiusIsZero()
        {
            Assert.Throws<ArgumentException>(() => _circle = new(0.0));
        }

        /// <summary>
        /// Check for ArgumentException (The radius of the circle is less than zero)
        /// Should throw away ArgumentException!
        /// </summary>
        [Test]
        public void CircleRadiusIsLessThanZero()
        {
            Assert.Throws<ArgumentException>(() => _circle = new(-0.5));
        }

        /// <summary>
        /// Checking the calculation of the area of the circle with accuracy
        /// </summary>
        [Test]
        public void CircleAreaDeltaCompute()
        {
            _circle = new(5.0);
            Assert.AreEqual(78.53981633, _circle.Area, Math.E, "Result out of range!");
        }
    }
}