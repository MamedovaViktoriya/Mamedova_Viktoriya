using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRound
{
    public class Round
    {
        public double X;
        public double Y;

        private double _r;
        public double R
        {
            get
            {
                return _r;
            }

            set
            {
                if (value >= 0)
                {
                    _r = value;
                }

                else
                {
                    throw new Exception("Введите положительный радиус!");
                }
            }

        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public double GetLength()
        {
            return 2 * Math.PI * R;
        }

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            R = radius;
        }

    }
}
