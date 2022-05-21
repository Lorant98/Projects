namespace LeetCode_41
{
    class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int j = nums[i];

                while (j > 0 && j <= nums.Length && nums[j - 1] != j)              
                    (j, nums[j - 1]) = (nums[j - 1], j);                
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    return i + 1;
            }

            return nums.Length + 1;
        }
    }
}
