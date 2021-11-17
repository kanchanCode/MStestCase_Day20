using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadMoodShouldReturnSAD()
        { 
            //Arrange
            string expected = "SAD";
            string message = "I am Sad Mood";
            UC1 moodTest = new UC1(message);

            //Act
            string mood = moodTest.Analyze();

            //Assert
            Assert.AreEqual(expected, mood);
        }
        [TestMethod]
        public void ShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            UC1 moodTest1 = new UC1(message);

            //Act
            string mood = moodTest1.Analyze();

            //Assert
            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void HAPPYShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
           // string message = "I am in Any Mood";
            UC1 moodTest2 = new UC1();

            //Act
            string mood = moodTest2.ForDefault();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
