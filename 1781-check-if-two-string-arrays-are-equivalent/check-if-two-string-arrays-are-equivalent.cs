public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int i = 0, j = 0;
        int index1 = 0, index2 = 0;
        
        while (index1 < word1.Length && index2 < word2.Length) {
            if (word1[index1][i] != word2[index2][j]) {
                return false;
            }
            
            i++;
            j++;
            
            if (i == word1[index1].Length) {
                i = 0;
                index1++;
            }
            
            if (j == word2[index2].Length) {
                j = 0;
                index2++;
            }
        }
        
        return index1 == word1.Length && index2 == word2.Length;
    }
}