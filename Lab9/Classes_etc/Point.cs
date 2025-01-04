namespace Lab91
{
    class Point : Figure
    {
        public Point(FigureStatus isVisible, double figureXPoint, double figureYPoint, string figureColor)
            : base(figureColor, isVisible, figureXPoint, figureYPoint) // Вызов конструктора базового класса
        {
        }
    }
}