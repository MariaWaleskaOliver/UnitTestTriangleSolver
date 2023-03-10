using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public class Isosceles
    {
        public double number1;
        public double number2;
        public double number3;

        public Isosceles(double number1, double number2, double number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;
        }
        public bool check2SizeseAquals(double number1, double number2, double number3)
        { 
            if((number1 == number2) || (number1 == number3))
            {
                return true;
            }
        return false;   
        }
        public bool checkThirdNumberSmaller(double number1, double number2, double number3)
        {
            if ((number1 == number2) &&  (number3 < number1))
            {
                return true;
            }
            else if ((number1 == number3) && (number2 < number1))
            {
                return true;
            }
            return false;
        }
        public bool checkZeroLengthIsosceles(int number1, int number2, int number3)
        {
            if ((number1 == 0) || (number2 == 0) || (number3 == 0))
            {
                return false;
            }
            return true;
        }
        public bool checkInvalidResponseIsosceles(int number1, int number2, int number3)
        {
            if ((number1 == -1) || (number2 == -1) || (number3 == -1))
            {
                return false;
            }
            return true;
        }
    }
}
