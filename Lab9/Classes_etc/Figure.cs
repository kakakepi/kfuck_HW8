namespace Lab9
{
    internal abstract class Figure : IGeometricFigure
    {
        internal string figureColor;
        internal FigureStatus isVisible;
        internal double figureXPoint;
        internal double figureYPoint;
        public Figure(string figureColor, FigureStatus isVisible)
        {
            this.figureColor = figureColor;
            this.isVisible = isVisible;
            figureXPoint = 0;
            figureYPoint = 0;
        }
        public Figure(string figureColor, FigureStatus isVisible, double figureXPoint, double figureYPoint)
        {
            this.figureColor = figureColor;
            this.isVisible = isVisible;
            this.figureXPoint = figureXPoint;
            this. figureYPoint = figureYPoint;
        }
        public string CheckFigureVisiblity()
        {
            return $"Статус видимости фигуры: {isVisible}";
        }
        public virtual void ChangeYCoordinate(double newYCoord)
        {
            this.figureYPoint += newYCoord;
        }
        public virtual void ChangeXCoordinate(double newXCoord)
        {
            this.figureXPoint += newXCoord;
        }
        public virtual void ChangeColor(string newColor)
        {
            this.figureColor = newColor;
        }
        public virtual void GetFigureInfo()
        {
            Console.WriteLine($"Координаты фигуры: ({figureXPoint},{figureYPoint}), цвет: {figureColor}, видимость: {isVisible}");
        }
    }
}