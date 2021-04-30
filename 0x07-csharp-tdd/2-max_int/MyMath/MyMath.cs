using System;

namespace MyMath
{
    public class Operations
    {
        public static int Max(System.Collections.Generic.List<int> nums)
        {
            int max = 0;
            if (nums.Count != 0)
            {
                nums.Sort();
                max = nums[nums.Count - 1];
            }
            return max;
        }
    }
}
