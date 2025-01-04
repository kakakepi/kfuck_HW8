namespace Lab91
{
    class Rectangle : Point
    {
        double firstSide;
        double secondSide;
        public Rectangle(FigureStatus isVisible, double figureXPoint, double figureYPoint, string figureColor,double firstSide, double secondSide)
            : base(isVisible, figureXPoint, figureYPoint, figureColor)
            {
                this.isVisible = isVisible;
                this.figureXPoint = figureXPoint;
                this.figureYPoint = figureYPoint;
                this.figureColor = figureColor;
                this.firstSide = firstSide;
                this.secondSide = secondSide;
            }
        public string RectangleArea()
        {
            return $"Площадь прямоугольника: {firstSide*secondSide}";
        }
    }
}