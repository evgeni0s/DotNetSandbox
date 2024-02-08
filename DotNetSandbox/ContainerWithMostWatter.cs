using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace DotNetSandbox
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/description/
    /// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    /// Find two lines that together with the x-axis form a container, such that the container contains the most water.
    /// Return the maximum amount of water a container can store.
    /// Notice that you may not slant the container.
    /// Input: height = [1,8,6,2,5,4,8,3,7]
    /// Output: 49
    /// Explanation: The above vertical lines are represented by array[1, 8, 6, 2, 5, 4, 8, 3, 7]. In this case, the max area of water (blue section) the container can contain is 49.
    /// Example 2:
    /// Input: height = [1, 1]
    /// Output: 1
    /// </summary>
    public class ContainerWithMostWatter
    {
        public int MaxArea(int[] height)
        {
            var leftPionter = 0; 
            var rightPionter = height.Length - 1;
            var maxArea = 0;

            while (leftPionter < rightPionter)
            {
                int currentArea = Math.Min(height[leftPionter], height[rightPionter]) * (rightPionter - leftPionter);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[leftPionter] < height[rightPionter])
                {
                    leftPionter++;
                }
                else
                {
                    rightPionter--;
                }
            }
            return maxArea;
        }
    }
}
