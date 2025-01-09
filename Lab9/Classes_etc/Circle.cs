namespace Lab9
{
    class Circle : Point , IGeometricFigure
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
        public override void GetFigureInfo()
        {
            Console.WriteLine($"Площадь круга: {Math.PI*Math.Pow(radius,2)}, Координаты фигуры: ({figureXPoint},{figureYPoint}), цвет: {figureColor}, видимость: {isVisible}");
        }
    }
}