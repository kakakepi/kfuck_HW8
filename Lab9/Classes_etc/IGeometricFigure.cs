namespace Lab91    
{
    interface IGeometricFigure
    {
        public void ChangeXCoordinate(double deltaX);
        public void ChangeYCoordinate(double deltaY);
        public void ChangeColor(string newColor);
        public string CheckFigureVisiblity();
    }
}