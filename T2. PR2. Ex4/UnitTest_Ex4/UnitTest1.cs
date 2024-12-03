using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace UnitTest_Ex4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Arrange
        [DataRow(3, 18.84955592153876, 0)]
       
        public void CalculateCircumfCorrect(double radius, double expected, double circumference)
        {
            //Act
            T2._PR2._Ex4.Program.CalculateCircumf( radius, circumference);
           //Assert
           Assert.AreEqual(expected, circumference);
        }

        [TestMethod]
        //Arrange
        [DataRow(3, 18, 0)]

        public void CalculateCircumfIncorrect(double radius, double expected, double circumference)
        {
            //Act
            T2._PR2._Ex4.Program.CalculateCircumf(radius, circumference);
            //Assert
            Assert.AreNotEqual(expected, circumference);
        }

        [TestMethod]
        //Arrange
        [DataRow(3, 4, 0, 12)]

        public static void CalculateAreaCorrect(double width, double height,  double area, double expected)
        {
            //Act
            T2._PR2._Ex4.Program.CalculateArea(width, height,  ref area);
            //Assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        //Arrange
        [DataRow(3, 4, 0, 13)]

        public static void CalculateAreaNotCorrect(double width, double height, double area, double expected)
        {
            //Act
            T2._PR2._Ex4.Program.CalculateArea(width, height, ref area);
            //Assert
            Assert.AreEqual(expected, area);
        }
    }
}