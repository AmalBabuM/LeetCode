public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int sum1 = (n*(n+1))/2;
        int sum2 = 0;

        for(int i=m; i<=n; i+=m){
            sum1 -= i;
            sum2 += i;
        }

        return sum1 - sum2; 
    }
}