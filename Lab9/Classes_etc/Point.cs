namespace Lab9
{
    class Point : Figure , IGeometricFigure
    {
        public Point(FigureStatus isVisible, double figureXPoint, double figureYPoint, string figureColor)
            : base(figureColor, isVisible, figureXPoint, figureYPoint)
        {
            this.isVisible = isVisible;
            this.figureXPoint = figureXPoint;
            this.figureYPoint = figureYPoint;
            this.figureColor = figureColor;
        }
        public override void ChangeYCoordinate(double newYCoord)
        {
            this.figureYPoint += newYCoord;
        }
        public override void ChangeXCoordinate(double newXCoord)
        {
            this.figureXPoint += newXCoord;
        }
        public override void ChangeColor(string newColor)
        {
            this.figureColor = newColor;
        }
        public override void GetFigureInfo()
        {
            Console.WriteLine($"Координаты фигуры: ({figureXPoint},{figureYPoint}), цвет: {figureColor}, видимость: {isVisible}");
        }
    }
}