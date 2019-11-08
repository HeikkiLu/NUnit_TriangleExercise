using System;

// Heikki Luukkonen

namespace NUnit_TriangleExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int side1, side2, side3;


            Console.WriteLine("Insert side 1 of triangle: ");
            side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert side 2 of triangle: ");
            side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert side 3 of triangle: ");
            side3 = int.Parse(Console.ReadLine());

            Checker Checker = new Checker();
            Checker.CheckSides(side1, side2, side3);

        }
    }
    class Checker
    {
        public void CheckSides(int x, int y, int z)
        {
            if(x == y && y == z)
            {
                Console.WriteLine("All triangle sides are equal.");
            }
            else if(x == y || x == z || y == z)
            {
                Console.WriteLine("Two of the triangle sides are equal.");
            }
            else
            {
                Console.WriteLine("All of the triangle sides are unequal.");
            }   
        }
    }
}
