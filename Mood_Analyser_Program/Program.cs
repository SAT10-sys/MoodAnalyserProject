using System;

namespace Mood_Analyser_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Mood Analyser Program ");
            Console.WriteLine(" Enter your message ");
            string message = Console.ReadLine();
            Console.WriteLine(" Mood is: "+ message);
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            moodAnalyser.AnalyseMood(message);
        }
    }
}
