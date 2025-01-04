namespace Lab91
{
    internal abstract class Figure
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
        public string CheckVigureVisiblity()
        {
            return $"Статус видимости фигуры: {isVisible}";
        }
        public void ChangeYCoordinate(double newYCoord)
        {
            this.figureYPoint += newYCoord;
        }
        public void ChangeXCoordinate(double newXCoord)
        {
            this.figureXPoint += newXCoord;
        }
        public void ChangeColor(string newColor)
        {
            this.figureColor = newColor;
        }
        public void GetFigureInfo()
        {
            Console.WriteLine($"Координаты фигуры: ({figureXPoint},{figureYPoint}), цвет: {figureColor}, видимость: {isVisible}");
        }
    }
}