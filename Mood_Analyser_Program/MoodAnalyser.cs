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
                if (message.ToUpper().Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(Exception e)
            {
                return "HAPPY";
            }
        }
    }
}
