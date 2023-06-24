namespace FigureSending.Figures
{
    abstract public class BaseFigure
    {
        private readonly List<double> sidesLength;
        
        public List<double> SidesLength => sidesLength;

        public BaseFigure(double singleLength)
        {
            this.sidesLength = new List<double> { singleLength };
        }

        public BaseFigure(ICollection<double> sidesLength)
        {
            if (sidesLength is null)
                throw new ArgumentNullException(nameof(sidesLength));

            this.sidesLength = sidesLength.OrderByDescending(side => side).ToList();
        }

        public abstract double GetArea();
    }
}