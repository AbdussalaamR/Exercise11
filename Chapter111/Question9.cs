using System;
using System.Collections;
using System.Collections.Generic;
namespace Chapter111
{
    public class Question9
    {
        public static void Answer(DateTime date)
        {
            int count = 0;
            int weekends = 0;
            for (DateTime i = DateTime.Now; i < date; i.AddDays(1))
            {
                if (i.ToString("ddd") == "Mon"||i.ToString("ddd") == "Tue"||i.ToString("ddd") == "Wed"||i.ToString("ddd") == "Thur"||i.ToString("ddd") == "Fri" )
                {
                    count++;
                }
                else if (i.ToString("ddd") == "Sat"||i.ToString("ddd") == "Sun")
                {
                    
                }
                { 
                    weekends++;
                }
                Console.WriteLine($"{count} worrkdays and {weekends} weekends");
            }
        }
    }
}