namespace Lab91
{
    class Point : Figure
    {
        public Point(FigureStatus isVisible, double figureXPoint, double figureYPoint, string figureColor)
            : base(figureColor, isVisible, figureXPoint, figureYPoint)
        {
            this.isVisible = isVisible;
            this.figureXPoint = figureXPoint;
            this.figureYPoint = figureYPoint;
            this.figureColor = figureColor;
        }
    }
}