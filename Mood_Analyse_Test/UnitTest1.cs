using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Program;
using System.Linq.Expressions;

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
        [TestMethod]
        public void TestCase1_2()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string resultMood = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", resultMood);
        }
        [TestMethod]
        public void TestCase2()
        {
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            string resultMood = moodAnalyser.AnalyseMood();

            Assert.AreEqual("HAPPY", resultMood);
        }
        [TestMethod]
        public void TestCase3_1()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string resultMood = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("Mood cannot be null", e.Message);
            }
        }
        [TestMethod]
        public void TestCase3_2()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string resultMood = moodAnalyser.AnalyseMood();
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("Mood cannot be empty", e.Message);
            }
        }
        [TestMethod]
        public void TestCase4_1()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProgram.MoodAnalyser", "MoodAnalyser");
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }
        [TestMethod]
        public void TestCase4_2()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProgram.MoodAnalyser", "MoodAnalyser");
            }
            catch(MoodAnalysisException e)
            {
                Assert.AreEqual("No such class found", e.Message);
            }
        }
        [TestMethod]
        public void TestCase4_3()
        {
            try
            {
                object expected = new MoodAnalyser();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProgram.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("No such constructor found", e.Message);
            }
        }
        [TestMethod]
        public void TestCase5_1()
        {
            string message = "HAPPY";
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProgram.MoodAnalyse", "MoodAnalyser", message);
            Assert.AreEqual(expected.GetType(), obj.GetType());
        }
        [TestMethod]
        public void TestCase5_2()
        {
            string message = "HAPPY";
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProgram.MoodAnalyse", "MoodAnalyser", message);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("No such class found", e.Message);
            }
        }
        [TestMethod]
        public void TestCase5_3()
        {
            string message = "HAPPY";
            try
            {
                object expected = new MoodAnalyser("Happy");
                object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProgram.MoodAnalyse", "MoodAnalyser", message);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual("No such constructor found", e.Message);
            }
        }
    }
}
