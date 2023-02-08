using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;



namespace TriangleTest
{
    [TestFixture]

    public class Class1
    {
        [Test]
        public void Valid_equilateral_triangle() 
        {
            Equilateral equilateral = new Equilateral(10, 10, 10);
            int expected = 10;
            int actual1 = equilateral.number1;
            int actual2 = equilateral.number2;
            int actual3 = equilateral.number3;
            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);

        }
        [Test]
        public void Check2equalsizes_isosceles_triangle() 
        {
            Isosceles isosceles = new Isosceles(10, 10, 5);
            bool expected = true;
            bool actual = isosceles.check2SizeseAquals(10, 10, 5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckSmallSize_isosceles_triangle()
        {
            Isosceles isosceles = new Isosceles(10, 10, 5);
            bool expected = true;
            bool actual = isosceles.checkThirdNumberSmaller(10, 10, 5);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckInvalid_isosceles_triangle()
        {
            Isosceles isosceles = new Isosceles(8, 10, 20);
            bool expected = false;
            bool actual = isosceles.check2SizeseAquals(8, 10, 20);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckAllDifferenteSizes_scalene_triangle() 
        {
            Scalene scalene = new Scalene(10, 20, 30);
            bool expected = true;
            bool actual = scalene.checkAllSizesDifferent(10, 20, 30);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void verifying_zero_length()
        {
            //Triangle triangle = new Triangle();
            
        }
        [Test]
        public void invalid_response() { }





    }
}
