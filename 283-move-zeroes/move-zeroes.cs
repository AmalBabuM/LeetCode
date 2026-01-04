public class Solution {
    public void MoveZeroes(int[] nums) {
        int k = 0;

        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] != 0) {
                (nums[i], nums[k]) = (nums[k], nums[i]);
                k++;
            }
        }
    }
}