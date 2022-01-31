using System.IO;
using System.Text;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Chapter111
{
    public class Question11
    {
        public static List<string> LaudPhrases= new List<string>() {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
        public static List<string> LaudStories = new List<string>() {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
        public static List<string> FirstNameAuthor = new List<string>() {"Dayan", "Stella", "Hellen", "Kate"};
        public static List<string> LastNameAuthor = new List<string>() {"Johnson", "Peterson", "Charls"};
        public static List<string> Cities = new List<string>() {"London", "Paris", "Berlin", "New York", "Madrid"};
        public static void LaudMessage()
        {
            Random rand = new Random();
            StringBuilder message = new StringBuilder();
            int index = rand.Next(LaudPhrases.Count);
            string phrase = LaudPhrases[index];
            int ind = rand.Next(LaudPhrases.Count);
            string story = LaudStories[ind];
            int inde = rand.Next(FirstNameAuthor.Count);
            string fName = FirstNameAuthor[inde];
            int i = rand.Next(LastNameAuthor.Count);
            string lName = LastNameAuthor[i];
            int j = rand.Next(Cities.Count);
            string city = Cities[j];
            message.Append(phrase);
            message.Append(story);
            message.Append(fName );
            message.Append(" ");
            message.Append(lName);
            message.Append(", ");
            message.Append(city);
            Console.WriteLine(message.ToString());

        }
        

    }
}