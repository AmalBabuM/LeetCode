public class Solution {
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);

var arr = new List<int>();

for (int i = 1; i < nums.Length; i += 2)
{
    arr.Add(nums[i]);
    arr.Add(nums[i - 1]);

}

return arr.ToArray();
    }
}