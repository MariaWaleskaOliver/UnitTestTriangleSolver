using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public class Scalene
    {
        public double number1;
        public double number2;
        public double number3;

        public Scalene(double number1, double number2, double number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
        }
        public bool checkAllSizesDifferent(double number1, double number2, double number3)
        {
            if ((number1 != number2) || (number1 != number3))
            {
                if (number2 != number3)
                {
                    return true;
                }

            }
            return false;

        }
    }
}
