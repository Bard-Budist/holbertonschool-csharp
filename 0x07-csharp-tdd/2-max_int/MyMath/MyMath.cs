using System;

namespace MyMath
{
    public class Operations
    {
        public static int Max(System.Collections.Generic.List<int> nums)
        {
            if (nums.Count == 0)
            {
                return 0;
            }

            int max = 0;
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
