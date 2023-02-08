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
        //Equilateral 
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
        //Isosceles
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
        //Scalene
        [Test]
        public void CheckAllDifferenteSizes_scalene_triangle() 
        {
            Scalene scalene = new Scalene(10, 20, 30, 10, 20,30, "nonexistent");
            bool expected = true;
            bool actual = scalene.checkAllSizesDifferent(10, 20, 30);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckInvalid_scalene_triangle()
        {
            Scalene scalene = new Scalene(10, 10, 10,10,10,10, "nonexistent");
            bool expected = false;
            bool actual = scalene.checkAllSizesDifferent(10, 10, 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckAllDifferentAngles_scalene_triangle()
        {
            Scalene scalene = new Scalene(10, 20, 30, 10, 20, 30, "nonexistent");
            bool expected = true;
            bool actual = scalene.checkAllAnguesDifferent(5, 10, 15);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckInvalidtAngles_scalene_triangle()
        {
            Scalene scalene = new Scalene(10, 10, 10, 10, 10, 10, "nonexistent");
            bool expected = false;
            bool actual = scalene.checkAllAnguesDifferent(10, 10, 10);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CheckSymmetrLine_scalene_triangle()
        {
            Scalene scalene = new Scalene(10, 10, 10, 10, 10, 10, "nonexistent");
            string expected = "nonexistent";
            string actual = scalene.CheckLineOfymmetrty("nonexistent");
            Assert.AreEqual(expected, actual);
        }
        //Checking 0 lenght for all triangles
        [Test]
        public void verifyingEquilateral_zero_length()
        {
            Equilateral equilateral = new Equilateral(10, 10, 10);
            bool expected = true;
            bool actual1 = equilateral.checkZeroLengthEquilateral(5, 10, 15);
            Assert.AreEqual(expected, actual1);
        }
        [Test]
        public void verifyingIsosceles_zero_length()
        {
            Isosceles isosceles = new Isosceles(8, 10, 20);
            bool expected = true;
            bool actual = isosceles.checkZeroLengthIsosceles(8, 10, 20);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void verifyingScalene_zero_length()
        {
            Scalene scalene = new Scalene(10, 10, 10, 10, 10, 10, "nonexistent");
            bool expected = true;
            bool actual = scalene.checkZeroLengthScalene(2, 4, 6);
            Assert.AreEqual(expected, actual);
        }
        //Invalid response
        [Test]
        public void invalid_response_Equilateral() 
        {
            Equilateral equilateral = new Equilateral(10, 10, 10);
            bool expected = false;
            bool actual1 = equilateral.checkInvalidResponseEquilateral(-1, -1, -1);
            Assert.AreEqual(expected, actual1);
        }
        [Test]
        public void invalid_response_Scalene()
        {
            Scalene scalene = new Scalene(10, 10, 10, 10, 10, 10, "nonexistent");
            bool expected = true;
            bool actual = scalene.CheckInvalideResponseScalene("nonexistent");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void invalid_response_Isosceles()
        {
            Isosceles isosceles = new Isosceles(8, 10, 20);
            bool expected = false;
            bool actual1 = isosceles.checkInvalidResponseIsosceles(-1, -1, -1);
            Assert.AreEqual(expected, actual1);
        }




    }
}
