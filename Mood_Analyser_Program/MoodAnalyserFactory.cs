using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Mood_Analyser_Program
{
    public class MoodAnalyserFactory
    {
        private string message;
        public MoodAnalyserFactory(string message)
        {
            this.message = message;
        }
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            try
            {
                Type moodAnalyserType = Type.GetType(className);
                object moodAnalyser = Activator.CreateInstance(moodAnalyserType);
                if (Regex.IsMatch(className, pattern) == false)
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No such constructor found");
                return moodAnalyser;
            }
            catch (ArgumentNullException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No such class found");
            }
        }
        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            string pattern = @"." + constructorName + "$";
            try
            {
                Type moodAnalyserType = Type.GetType(className);
                ConstructorInfo constructorInfo = moodAnalyserType.GetConstructor(new Type[] { typeof(string) });
                if (Regex.IsMatch(className, pattern) == false)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No such constructor found");
                }
                object moodAnalyser = constructorInfo.Invoke(new object[] { message });
                return moodAnalyser;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "No such class found");
            }
        }
    }
}
