using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserException:Exception
    {
        public enum ExceptionType
        {
            NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType exceptionType;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
