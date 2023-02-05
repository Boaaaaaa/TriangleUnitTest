/*
 *  TriangleTest.cs
 *  Assignment2
 * 
 *  Revision History
 *      Boa Im, 2023.02.05: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTest
    {
        // 1 Equilateral Triangle
        [Test]
        public void ValidEquilateralTriangle_Input10and10and10_OutputValidTriangle()
        {
            //Arange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        // 3 Isosceles Triangles
        [Test]
        public void ValidIsoscelesTriangle_Input10and10and15_OutputValidTriangle()
        {
            //Arange
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 15;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input5and5and3_OutputValidTriangle()
        {
            //Arange
            int firstSide = 5;
            int secondSide = 5;
            int thirdSide = 3;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidIsoscelesTriangle_Input7and7and8_OutputValidTriangle()
        {
            //Arange
            int firstSide = 7;
            int secondSide = 7;
            int thirdSide = 8;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        // 5 Scalene Triangles
        [Test]
        public void ValidScaleneTriangle_Input3and4and5_OutputValidTriangle()
        {
            //Arange
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input5and12and13_OutputValidTriangle()
        {
            //Arange
            int firstSide = 5;
            int secondSide = 12;
            int thirdSide = 13;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input7and24and25_OutputValidTriangle()
        {
            //Arange
            int firstSide = 7;
            int secondSide = 24;
            int thirdSide = 25;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input8and15and17_OutputValidTriangle()
        {
            //Arange
            int firstSide = 8;
            int secondSide = 15;
            int thirdSide = 17;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ValidScaleneTriangle_Input9and10and11_OutputValidTriangle()
        {
            //Arange
            int firstSide = 9;
            int secondSide = 10;
            int thirdSide = 11;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            //Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, result);
        }

    }
}
