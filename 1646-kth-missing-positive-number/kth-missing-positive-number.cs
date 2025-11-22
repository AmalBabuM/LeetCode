public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        List<int> a=new List<int>();int count=0;int f=0;
        for(int i=1;i<2500;i++)
        {
            f=0;
            foreach(var j in arr)
            {
                if(i==j) f=1;
            }
            if(f!=1)
            {
                a.Add(i);
            }
        }
        int[] b=a.ToArray();
        return b[k-1];

    }
}