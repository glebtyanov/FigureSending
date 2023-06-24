namespace FigureSending.Figures.Tests
{
    public class BaseFigureTests
    {
        [Fact]
        public void BaseFigure_ConstructWithSingleLength_SetsSidesLengthCorrectly()
        {
            // Arrange
            double singleLength = 5.0;

            // Act
            var figure = new TestBaseFigure(singleLength);

            // Assert
            Assert.Single(figure.SidesLength);
            Assert.Equal(singleLength, figure.SidesLength[0]);
        }

        [Fact]
        public void BaseFigure_ConstructWithSidesLength_SetsSidesLengthCorrectly()
        {
            // Arrange
            var sidesLength = new List<double> { 3.0, 4.0, 5.0 };

            // Act
            var figure = new TestBaseFigure(sidesLength);

            // Assert
            Assert.Equal(sidesLength.Count, figure.SidesLength.Count);
            Assert.Equal(sidesLength.OrderByDescending(side => side), figure.SidesLength);
        }

        [Fact]
        public void BaseFigure_ConstructWithNullSidesLength_ThrowsArgumentNullException()
        {
            // Arrange
            List<double> sidesLength = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new TestBaseFigure(sidesLength));
        }

        private class TestBaseFigure : BaseFigure
        {
            public TestBaseFigure(double singleLength) : base(singleLength)
            {
            }

            public TestBaseFigure(ICollection<double> sidesLength) : base(sidesLength)
            {
            }

            public override double GetArea()
            {
                throw new NotImplementedException();
            }
        }
    }
}
