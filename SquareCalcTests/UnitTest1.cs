namespace SquareCalcTests
{
    public class Tests
    {

        [Test]
        public void CircleTest()
        {
            //arrange
            double arg1 = 2;
            double expected = 12.56;
            IFigure figure = FigureFabric.CreateFigure(arg1);
            //act
            double Squarefigure = figure.calculateSquare();
            //assert
            Assert.AreEqual(expected, Squarefigure, 0.01);
        }

        [Test]
        public void TriangleTest()
        {
            //arrange
            double arg1 = 4;
            double arg2 = 7;
            double arg3 = 9;
            double expected = 13.41;
            IFigure figure = FigureFabric.CreateFigure(arg1, arg2, arg3);
            //act
            double Squarefigure = figure.calculateSquare();
            //assert
            Assert.AreEqual(expected, Squarefigure, 0.01);
        }

        [Test]
        public void IsTriangalRectangular()
        {
            //arrange
            double arg1 = 3;
            double arg2 = 4;
            double arg3 = 5;
            bool expected = true;
            Triangle triangle = new Triangle(arg1, arg2, arg3);
            //act
            bool isTriangleRectangular = triangle.IsTriangleRectangular();
            //assert
            Assert.AreEqual(expected, isTriangleRectangular);
        }
        [Test]
        public void NegativeParamTest()
        {
            //arrange
            double arg1 = -2;
            //act
            var ex = Assert.Throws<ArgumentException>(() => FigureFabric.CreateFigure(arg1));
            //assert
            Assert.AreEqual("Введено отрицательное значение/значения <0 ", ex.Message);
        }
        [Test]
        public void WrongPagamsCountTest()
        {
            //arrange
            double arg1 = 3;
            double arg2 = 4;
            //act
            var ex = Assert.Throws<ArgumentException>(() => FigureFabric.CreateFigure(arg1,arg2));
            //assert
            Assert.AreEqual("Некорректное количество параметров", ex.Message);
        }

    }
}