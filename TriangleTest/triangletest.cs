using NUnit.Framework;
using NUnit_TriangleExercise;

namespace TriangleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Repeat(5)]
        public void EqualTriangle()
        {
            // Arrange
            Checker Checker = new Checker();
            int x = 20;
            int y = 20;
            int z = 20;
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
            Checker Checker = new Checker();
            int x = 20;
            int y = 20;
            int z = 10;
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
            Checker Checker = new Checker();
            int x = 30;
            int y = 20;
            int z = 10;
            string oletus = "All of the triangle sides are unequal.";
            // Act
            string tulos = Checker.CheckSides(x, y, z);
            // Assert
            Assert.AreEqual(oletus, tulos);
        }
    }
}