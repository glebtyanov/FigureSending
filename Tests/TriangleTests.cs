using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FigureSending.Figures.Tests
{

    public class TriangleTests
    {
        [Fact]
        public void Triangle_ConstructWithSidesLength_SetsSidesLengthCorrectly()
        {
            // Arrange
            var sidesLength = new List<double> { 3.0, 4.0, 5.0 };

            // Act
            var triangle = new Triangle(sidesLength);

            // Assert
            Assert.Equal(sidesLength.Count, triangle.SidesLength.Count);
            Assert.Equal(sidesLength.OrderByDescending(side => side), triangle.SidesLength);
        }

        [Fact]
        public void Triangle_ConstructWithSidesLength_SetsIsRightCorrectlyForNotRightTriangle()
        {
            // Arrange
            var sidesLength = new List<double> { 3.0, 4.1, 5.0 };

            // Act
            var triangle = new Triangle(sidesLength);

            // Assert
            Assert.False(triangle.IsRight);
        }

        [Fact]
        public void Triangle_ConstructWithSidesLength_SetsIsRightCorrectlyForRightTriangle()
        {
            // Arrange
            var sidesLength = new List<double> { 5.0, 12.0, 13.0 };

            // Act
            var triangle = new Triangle(sidesLength);

            // Assert
            Assert.True(triangle.IsRight);
        }

        [Fact]
        public void Triangle_GetArea_ReturnsCorrectAreaForNonRightTriangle()
        {
            // Arrange
            var sidesLength = new List<double> { 3.0, 4.0, 5.0 };
            double halfPerimeter = sidesLength.Sum() / 2;
            double expectedArea = Math.Sqrt(halfPerimeter * (halfPerimeter - sidesLength[0]) * (halfPerimeter - sidesLength[1]) * (halfPerimeter - sidesLength[2]));

            var triangle = new Triangle(sidesLength);

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }

        [Fact]
        public void Triangle_GetArea_ReturnsCorrectAreaForRightTriangle()
        {
            // Arrange
            var sidesLength = new List<double> { 5.0, 12.0, 13.0 };
            double expectedArea = sidesLength[0] * sidesLength[1] / 2;

            var triangle = new Triangle(sidesLength);

            // Act
            double actualArea = triangle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }
    }
}
