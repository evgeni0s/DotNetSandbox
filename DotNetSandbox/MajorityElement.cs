using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DotNetSandbox
{
    /// <summary>
    /// Given an array nums of size n, return the majority element.
    /// The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
    /// Example 1:
    /// Input: nums = [3, 2, 3]
    /// Output: 3
    /// Example 2:
    /// Input: nums = [2, 2, 1, 1, 1, 2, 2]
    /// Output: 2
    /// </summary>
    public class MajorityElement
    {
        public int Calc(int[] nums)
        {
            var occurences = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                if (!occurences.ContainsKey(nums[i]))
                {
                    occurences.Add(nums[i], 1);
                    continue;
                }
                occurences[nums[i]]++;
            }

            var result = occurences.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            return result;
        }
    }
}
