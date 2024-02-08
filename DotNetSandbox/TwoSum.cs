namespace DotNetSandbox
{
    public class TwoSum
    {
        public int[] Run(int[] nums, int target)
        {
            for (int start = 0; start < nums.Length - 1; start++) // -1 because it is a window fnction
            {
                for (int end = start + 1; end < nums.Length; end++)
                {
                    var sum = nums[start] + nums[end];
                    if (sum == target)
                    {
                        return [start, end];
                    }
                }
            }
            return null;
        }
    }
}
