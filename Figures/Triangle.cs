namespace FigureSending.Figures
{
    public class Triangle : BaseFigure
    {
        private readonly bool isRight;

        public bool IsRight => isRight;

        public Triangle(ICollection<double> sidesLength) : base(sidesLength)
        {
            isRight = Math.Pow(SidesLength[0], 2) == Math.Pow(SidesLength[1], 2) + Math.Pow(SidesLength[2], 2);
        }

        public override double GetArea()
        {
            // heron's formula S = sqrt(p(p-a)(p-b)(p-c)) where p is (a+b+c) / 2
            if (!isRight)
            {
                double halfPerimeter = SidesLength.Sum() / 2;

                return Math.Sqrt(halfPerimeter * (halfPerimeter - SidesLength[0]) * (halfPerimeter - SidesLength[1]) * (halfPerimeter - SidesLength[2]));
            }

            // for right triangle S = ab / 2 where a, b are catheds
            return SidesLength[1] * SidesLength[2] / 2;
        }
    }
}