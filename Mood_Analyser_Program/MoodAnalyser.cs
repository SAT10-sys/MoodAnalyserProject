using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Program
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
            message = "";
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message == "")
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Mood cannot be empty");
                }
                if (message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood cannot be null");
            }
        }
    }
}
