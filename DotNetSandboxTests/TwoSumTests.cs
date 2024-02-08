using DotNetSandbox;

namespace DotNetSandboxTests
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] TwoSum_ValidData(int[] nums, int target)
        {
            // Arrange
            var program = new TwoSum();

            // Act
            return program.Run(nums, target);
        }
    }
}