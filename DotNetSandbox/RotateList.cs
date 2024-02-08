using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSandbox
{
    /// <summary>
    /// From leetcode. 
    /// Given the head of a linked list, rotate the list to the right by k places.
    /// </summary>
    public class RotateList
    {
        
        public ListNode RotateRight(ListNode head, int k)
        {
            // Check if the list is empty or k is 0
            if (head == null || k == 0)
                return head;

            // Calculate the length of the linked list
            int length = 1; // Start from 1 because head is already counted
            ListNode tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
                length++;
            }

            // Adjust k if it's larger than the length of the list
            k = k % length;

            // Check if k becomes 0 after adjustment
            if (k == 0)
                return head;

            // Find the new head position after rotation
            int stepsToNewHead = length - k;
            ListNode newTail = head;
            for (int i = 1; i < stepsToNewHead; i++)
            {
                newTail = newTail.next;
            }

            // Update the pointers to rotate the list
            ListNode newHead = newTail.next;
            newTail.next = null; // Set the new tail's next pointer to null
            tail.next = head; // Connect the original tail to the original head

            return newHead;
        }
    }

    /*
             public ListNode RotateRight(ListNode head, int k)
        {
            var current = head;
            var queueSize = 0;
            LinkedList<ListNode> nodesToMove = new LinkedList<ListNode>();
            while (current != null)
            {
                nodesToMove.AddFirst(current);
                queueSize ++;
                if (queueSize > k + 1)
                {
                    nodesToMove.RemoveLast();
                    queueSize--;
                }
                current = current.next;
            }

            while (nodesToMove.Count > 1)
            {
                var node = nodesToMove.First;
                node.Value.next = head;
                head = node.Value;
                nodesToMove.RemoveFirst();
            }

            // last item is left, should not be moved
            nodesToMove.First.Value.next = null;
            return head;
        }
     
     */

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
            this.val = val;
            this.next = next;
      }
    }

    public class LinkedListBuilder
    {
        public static ListNode ConstructLinkedList(int[] array)
        {
            ListNode dummy = new ListNode(); // Dummy node to start the linked list
            ListNode current = dummy;

            foreach (int val in array)
            {
                current.next = new ListNode(val);
                current = current.next;
            }

            return dummy.next; // Return the actual head of the linked list
        }

        public static int[] ConvertToArray(ListNode head)
        {
            List<int> result = new List<int>();
            ListNode current = head;

            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }

            return result.ToArray();
        }
    }
}
