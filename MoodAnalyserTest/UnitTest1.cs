using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Program;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            string message = " I am in Sad Mood ";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string resultMood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("SAD", resultMood);
        }
        public void TestCase1_2()
        {
            string message = " I am in Any Mood ";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string resultMood = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual("HAPPY", resultMood);
        }
    }
}
