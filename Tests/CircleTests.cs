namespace FigureSending.Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_ConstructWithRadius_SetsSidesLengthCorrectly()
        {
            // Arrange
            double radius = 7.5;

            // Act
            var circle = new Circle(radius);

            // Assert
            Assert.Single(circle.SidesLength);
            Assert.Equal(radius, circle.SidesLength[0]);
        }

        [Fact]
        public void Circle_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 7.5;
            double expectedArea = Math.PI * Math.Sqrt(radius);

            var circle = new Circle(radius);

            // Act
            double actualArea = circle.GetArea();

            // Assert
            Assert.Equal(expectedArea, actualArea, precision: 5);
        }
    }
}
