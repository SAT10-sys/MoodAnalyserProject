using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Program;

namespace Mood_Analyse_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string resultMood = moodAnalyser.AnalyseMood();

            Assert.AreEqual("SAD", resultMood);
        }
        public void TestCase1_2()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string resultMood = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", resultMood);
        }
        public void TestCase2()
        {
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string resultMood = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", resultMood);
        }
    }
}
