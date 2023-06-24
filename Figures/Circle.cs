namespace FigureSending.Figures
{
    public class Circle : BaseFigure
    {
        public Circle(double radius) : base(radius)
        {
        }

        public override double GetArea()
        {
            // S = Pi * r^2
            return Math.PI * Math.Sqrt(SidesLength[0]);
        }
    }
}