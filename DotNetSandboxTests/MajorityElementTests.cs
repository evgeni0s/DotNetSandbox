using DotNetSandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSandboxTests
{
    public class MajorityElementTests
    {
        [Test]
        [TestCase(new int[] { 3, 2, 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { 2, 2, 1, 1, 1, 2, 2 }, ExpectedResult = 2)]
        public int MajorityElement_ValidData(int[] nums)
        {
            // Arrange
            var sut = new MajorityElement();

            // Act
            var result = sut.Calc(nums);

            // Assert
            return result;
        }
    }
}
