using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserException:Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
