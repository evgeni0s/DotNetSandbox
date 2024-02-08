using DotNetSandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSandboxTests
{
    public class RotateListTests
    {
        [Test]
        public void RotateList_ValidData()
        {
            // Arrange
            var program = new RotateList();
            int[] array = { 1, 2, 3, 4, 5 };
            ListNode head = LinkedListBuilder.ConstructLinkedList(array);

            // Act
            var result = program.RotateRight(head, 2);

            // Assert
            var resutArray = LinkedListBuilder.ConvertToArray(result);
            Assert.That(new int[] { 4, 5, 1, 2, 3 }, Is.EqualTo(resutArray));
        }

        [Test]
        [TestCase(new int[] { 0, 1, 2 }, 1, ExpectedResult = new int[] { 2, 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 }, 2, ExpectedResult = new int[] { 1, 2, 0 })]
        [TestCase(new int[] { 0, 1, 2 }, 3, ExpectedResult = new int[] { 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2 }, 4, ExpectedResult = new int[] { 2, 0, 1 })]
        public int[] RotateList_ShortArray(int[] array, int k)
        {
            // Arrange
            var program = new RotateList();

            ListNode head = LinkedListBuilder.ConstructLinkedList(array);

            // Act
            var result = program.RotateRight(head, k);

            // Assert
            var resutArray = LinkedListBuilder.ConvertToArray(result);
            return resutArray;
        }
    }
}
