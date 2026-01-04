public class Solution {
    public int MinOperations(IList<int> nums, int k) {
        long elements = 1;
        long result = (1L << (k + 1)) - 1;
        for (var i = nums.Count - 1; i >= 0; i--) {
            if (nums[i] <= k) 
            {
                elements |= (1L << nums[i]);
                if (elements == result) 
                {
                    return nums.Count - i;
                }
            }
        }
        return 0;
    }
}