using System;
namespace Chapter111
{
    
    public class Question6
    {
        public static void ThreeSides(double b, double h, double L = 0)
        {
            Console.Write($"Area = {0.5 * b * h}");
        }

        public static void SideNAngle()
        {
            Console.WriteLine("Length of the first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Length of the second side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Angle in degrees:");
            int angleInDeg = int.Parse(Console.ReadLine());
            double angleInRad = Math.PI * angleInDeg / 180.0;
            Console.WriteLine($"Area of the triangle: 0.5 * {a} * {b} * {Math.Sin(angleInRad)}");
        }
    }

    // Question7
    // namespace CreatingAndUsingObjects
    // {
    //     public class Cat
    //     {
            
    //     }
    //     public class Sequence
    //     {

    //     }

    //     namespace AnotherNamespace
    //     {
    //         class CallPreviousClass
    //         {
    //          Chapter111.CreatingAndUsingObjects.AnotherNamespace.Cat   
            
    //         }
        
    //     }
    // }
}