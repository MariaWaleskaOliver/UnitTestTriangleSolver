using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public class Equilateral
    {
        public int number1;
        public int number2;
        public int number3;

        public Equilateral(int number1, int number2, int number3)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.number3 = number3;

        }
        public bool checkZeroLengthEquilateral(int number1, int number2, int number3)
        {
            if((number1 == 0) || (number2 == 0) || (number3 == 0))
            {
                return false;
            }
            return true;
        }
        public bool checkInvalidResponseEquilateral(int number1, int number2, int number3)
        {
            if ((number1 == -1) || (number2 == -1) || (number3 == -1))
            {
                return false;
            }
            return true;
        }
      
    }
}
