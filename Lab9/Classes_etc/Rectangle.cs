namespace Lab9
{
    class Rectangle : Point , IGeometricFigure
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
        
        public override void GetFigureInfo()
        {
            Console.WriteLine($"Площадь прямоугольника: {firstSide*secondSide}, Координаты фигуры: ({figureXPoint},{figureYPoint}), цвет: {figureColor}, видимость: {isVisible}");
        }
    }
}