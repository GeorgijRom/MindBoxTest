namespace SquareCalc
{
    public interface IFigure
    {
        double calculateSquare();
    }

    public class Circle : IFigure
    {
        public double R { get; }

        public Circle(double r) => R = r;

        public double calculateSquare()
        {
            return Math.PI * R * R;
        }
    }
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c) => (A, B, C) = (a, b, c);

        public double calculateSquare() // Вычисляем площадь по Герону
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsTriangleRectangular() // Проверка прямоугольный ли треугольник
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);
            bool isRectangular = sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
            return isRectangular;
        }
    }
    public class FigureFabric
    {
        public static IFigure CreateFigure(params double[] parameters)
        {
            if (parameters.All(element => element >= 0)) // Проверка на правильность введенных значений
            {
                switch (parameters.Length)
                {
                    case 1:
                        // Строим круг

                        return new Circle(parameters[0]);

                    case 3:
                        // Строим треугольник
                        return new Triangle(parameters[0], parameters[1], parameters[2]);
                    // Аналогично можно добавить другие фигуры
                    default:
                        throw new ArgumentException("Некорректное количество параметров");
                }
            }
            else
                throw new ArgumentException("Введено отрицательное значение/значения <0 ");
        }
    }
    
}