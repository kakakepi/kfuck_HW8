namespace Lab91
{
    class Circle : Point
    {
        double radius;
        public Circle(FigureStatus isVisible, double figureXPoint, double figureYPoint, string figureColor, double radius)
            : base(isVisible, figureXPoint, figureYPoint, figureColor)
        {
            this.figureColor = figureColor;
            this.isVisible = isVisible;
            this.figureYPoint = figureYPoint;
            this.figureXPoint = figureXPoint;
            this.radius = radius;
        }
        public string CircleRadius()
        {
            return $"Площадьа круга: {Math.PI*Math.Pow(radius,2)}";
        }
    }
}