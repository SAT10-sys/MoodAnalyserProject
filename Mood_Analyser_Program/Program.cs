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
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine(" Mood is: " + moodAnalyser.AnalyseMood(message));
        }
    }
}
