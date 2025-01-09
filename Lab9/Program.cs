namespace Lab9
{
    class Program
    {
        static void Main()
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            Console.WriteLine("Упражнение 10.1. Создать интерфейс ICipher, который определяет методы поддержки шифрования строк.");
            string text = "Hello, World!";
            ICipher aCipher = new ACipher();
            string encodedACipher = aCipher.Encode(text);
            string decodedACipher = aCipher.Decode(encodedACipher);
            Console.WriteLine($"ACipher Encode: {encodedACipher}");
            Console.WriteLine($"ACipher Decode: {decodedACipher}");
            ICipher bCipher = new BCipher();
            string encodedBCipher = bCipher.Encode(text);
            string decodedBCipher = bCipher.Decode(encodedBCipher);
            Console.WriteLine($"BCipher Encode: {encodedBCipher}");
            Console.WriteLine($"BCipher Decode: {decodedBCipher}");
        }
        static void Task2()
        {
            Console.WriteLine("Домашнее задание 10.1. Создать класс Figure для работы с геометрическими фигурами. В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта. Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle добавить метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.");
            Console.WriteLine("Точка:");
            Point point = new Point(FigureStatus.Видимый, 4, 6, "Красный");
            point.GetFigureInfo();
            point.ChangeXCoordinate(5);
            point.ChangeYCoordinate(-3);
            point.GetFigureInfo();

            Console.WriteLine("\nКруг:");
            Circle circle = new Circle(FigureStatus.Видимый, 3, 5, "Синий", 35);
            circle.GetFigureInfo();
            circle.ChangeXCoordinate(5);
            circle.ChangeYCoordinate(-3);
            circle.GetFigureInfo();

            Console.WriteLine("\nПрямоугольник:");
            Rectangle rectangle = new Rectangle(FigureStatus.Невидимый,5,6,"Розовый",5,5);
            rectangle.GetFigureInfo();
            rectangle.ChangeXCoordinate(5);
            rectangle.ChangeYCoordinate(-3);
            rectangle.GetFigureInfo();

        }
    }
}