public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] arr= new int[2*nums.Length];
        for(int i=0; i<arr.Length;i++)
        {
            arr[i]=nums[i%nums.Length];
        }

        return arr;
    }
}