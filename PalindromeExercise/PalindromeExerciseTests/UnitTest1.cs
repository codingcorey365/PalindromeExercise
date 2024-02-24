using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        [InlineData("Racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("kayak", true)]
        [InlineData("john", false)]
        [InlineData("jose", false)]
        [InlineData("amoriss", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsPalindromeTest(string word, bool expected)
        {
            //Arrange
            WordSmith ws = new WordSmith();
            
            //Act
            var actual = ws.IsAPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
