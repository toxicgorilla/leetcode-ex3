using Should;
using Xunit;

namespace LeetCode.Ex3.Test
{
    public class SolutionShould
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("", 0)]
        [InlineData(" ", 1)]
        [InlineData("b", 1)]
        public void ShouldReturnCorrectResultWhenSolutionExists(string input, int expectedOutput)
        {
            // Act
            var solution = new Solution();
            var actualOutput = solution.LengthOfLongestSubstring(input);

            // Assert
            actualOutput.ShouldEqual(expectedOutput);
        }
    }
}
