public class Solution {
    public int DifferenceOfSum(int[] nums) {
       int sum=0;
       for(int i=0;i<nums.Length;i++)
       {
        sum +=nums[i];
       } 

        string alphaVal = string.Join("", nums);
        char[] chars = alphaVal.ToCharArray();

        int digitalSum = 0;
        foreach (char c in chars)
        {
            if (char.IsDigit(c))
                digitalSum += Convert.ToInt32(c.ToString());
        }
        int diff = sum-digitalSum;
        return diff;
    }
}