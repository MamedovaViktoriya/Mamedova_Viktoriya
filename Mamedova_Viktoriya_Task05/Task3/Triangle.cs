using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle
{
    public class ClassTriangle
    {
        private double a;
        public double A
        {
            get
            {
                return a;
            }

            set
            {
                if (value > 0)
                {
                    a = value;
                }

                else
                {
                    throw new Exception("Сторона треугольника должна быть больше нуля!");
                }
            }
        }

        private double b;
        public double B
        {
            get
            {
                return b;
            }

            set
            {
                if (value > 0)
                {
                    b = value;
                }

                else
                {
                    throw new Exception("Сторона треугольника должна быть больше нуля!");
                }
            }
        }

        private double c;
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }

                else
                {
                    throw new Exception("Сторона треугольника должна быть больше нуля!");
                }
            }
        }

        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }

        public double P
        {
            get
            {
                return (a + b + c) / 2;
            }
        }

        public double Square
        {
            get
            {
                return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            }
        }

        public ClassTriangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                A = a;
                B = b;
                C = c;
            }

            else throw new Exception("Сторона треугольника не может быть больше суммы двух других его сторон!");
        }
    }
}
