using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC3
        //TC 3.2
        [TestMethod]
        public void GivenEmptyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string message = string.Empty;
            MoodAnalyser moodAnalyzer = new MoodAnalyser(message);
            try
            {
                string actutal = moodAnalyzer.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }

    }
}
