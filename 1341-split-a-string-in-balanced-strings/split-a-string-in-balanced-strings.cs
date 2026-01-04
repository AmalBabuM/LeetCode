public class Solution {
    public int BalancedStringSplit(string s) {
        
        int count = 0;
        int R =0, L = 0;

        for ( int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'L')
                L++;
            else 
                R++;
            
            if (L == R)
            {
                count++;
            }
                
        }

        return count;
    }
}