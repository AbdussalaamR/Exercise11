using System;
using System.Collections;
using System.Collections.Generic;namespace Chapter111
{
    public class Question10
    {
        public static void AddString(string a)
        {
            int sum = 0;
            String [] b = a.Split(" ");
            foreach (var item in b)
            {
                sum += int.Parse(item);
            }
            Console.WriteLine(sum);
        }
    }
}