using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SquareCalc
{
    public  class GeometricFigures
    {
        public  double Triangle(double a, double b, double c)
        {
            bool isRightTriangle = false;
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) //проверка является ли треугольник прямоугольным
            {
                isRightTriangle = true;
            }
            if((a<0)||(b<0)||(c<0)||(a>b+c)||(b>a+c)||(c>a+b))//защита от неправильного ввода
            {
                Console.WriteLine("Such triangle can not exist");
                return -1;
            }
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }
        public  double Circle(double r)
        {
            if(r<0)
            {
                Console.WriteLine("Such circle can not exist");
                return -1;
            }
            return Math.PI*r*r;
        }
    }
}
