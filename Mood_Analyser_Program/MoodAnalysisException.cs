using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Program
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, 
            EMPTY_MESSAGE
        }
        ExceptionType type;
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
