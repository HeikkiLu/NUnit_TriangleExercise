using NUnit.Framework;
using NUnit_TriangleExercise;

namespace TriangleTest
{
    public class Tests
    {
        Checker Checker = new Checker();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Repeat(5)]
        public void EqualTriangle()
        {
            // Arrange
            double x = 20.0;
            double y = 20.0;
            double z = 20.0;
            string oletus = "All triangle sides are equal.";
            // Act
            string tulos = Checker.CheckSides(x, y, z);
            // Assert
            Assert.AreEqual(oletus, tulos);
        }
        [Test]
        [Repeat(5)]
        public void TwoSidesEqualTriangle()
        {
            // Arrange
            double x = 20;
            double y = 20;
            double z = 20.5;
            string oletus = "Two of the triangle sides are equal.";
            // Act
            string tulos = Checker.CheckSides(x, y, z);
            // Assert
            Assert.AreEqual(oletus, tulos);
        }
        [Test]
        [Repeat(5)]
        public void UnequalTriangle()
        {
            // Arrange
            double x = 30.1;
            double y = 20.5;
            double z = 10;
            string oletus = "All of the triangle sides are unequal.";
            // Act
            string tulos = Checker.CheckSides(x, y, z);
            // Assert
            Assert.AreEqual(oletus, tulos);
        }
    }
}