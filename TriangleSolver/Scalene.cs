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
        public double angle1;
        public double angle2;
        public double angle3;

        public Scalene(double number1, double number2, double number3, double angle1, double angle2, double angle3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
            this.angle1 = angle1;
            this.angle2 = angle2;
            this.angle3 = angle3;
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
        public bool checkAllAnguesDifferent(double angle1, double angle2, double angle3)
        {
            if (( angle1 != angle2) || (angle1 != angle3))
            {
                if (angle2 != angle3)
                {
                    return true;
                }

            }
            return false;

        }


    }
}
