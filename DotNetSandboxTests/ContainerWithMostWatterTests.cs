using DotNetSandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSandboxTests
{
    public class ContainerWithMostWatterTests
    {
        [Test]
        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, ExpectedResult = 49)]
        public int ContainerWithMostWatter_ValidData(int[] height)
        {
            // Arrange
            var sus = new ContainerWithMostWatter();

            // Act
            return sus.MaxArea(height);

            // Assert


        }
    }
}
