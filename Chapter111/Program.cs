using System.IO;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Chapter111
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            // Console.Write("Enter year: ");
            // int year = int.Parse(Console.ReadLine());
            // bool isLeap = IfLeap(year);
            // Console.WriteLine("Is " + year + " a leap year? " + isLeap);

            // OR
            // Console.WriteLine(DateTime.IsLeapYear(year));

            // Question 2
            // GenerateRandomNUm();

            // Question 3
            // Console.WriteLine(DateTime.Now.DayOfWeek);

            // Question 4
            // TimeElapsed();
            // Question 5
            // Pythagoras();

            // Question  6
            // Question6.ThreeSides(3, 4, 5);
            // Question6.SideNAngle();

            // DateTime date = new DateTime(2022, 02, 25);
            // Question9.Answer(date);
            

            // Question10.AddString("43 68 9 23 318");
            Question11.LaudMessage();

        }


        // Question 1
        public static bool IfLeap(int year)
        {
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        // Question 2
        public static void GenerateRandomNUm()
        {
            int [] num = new int [10];
            for (int i = 0; i < num.Length; i++)
            {
                Random rand = new Random();
                num[i] = rand.Next(100, 200);
                Console.WriteLine(num[i]);
            }
            
        }

        // Question 4
        public static void TimeElapsed()
        {
            int timeElapsed = Environment.TickCount;
             int totalSecs = timeElapsed / 1000;
            int days = totalSecs / (60 * 60 * 24);
            int remainingSec = totalSecs % (60 * 60 * 24);
            int hours = remainingSec / (60 * 60);
            remainingSec = remainingSec % (60 * 60);
            int mins = remainingSec / 60 ;
            int secs = remainingSec % 60;
            Console.WriteLine($"Time elapsed is {days}, {hours}, {mins}, {secs}");
        }
            // Question 5
        public static void Pythagoras()
        {
            Console.WriteLine("Length of the first side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Length of the second side:");
            double b = double.Parse(Console.ReadLine());
            double h = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine($"Hypothenus = {h}");
        }
        
        
    }
}
