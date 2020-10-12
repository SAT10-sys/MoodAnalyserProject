using System;

namespace Mood_Analyser_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Mood Analyser Program ");
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();

            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            Console.WriteLine("Mood is :" + moodAnalyser.AnalyseMood());
        }
    }
}
