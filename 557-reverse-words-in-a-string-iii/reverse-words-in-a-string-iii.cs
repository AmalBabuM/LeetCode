public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split();

        for(int i=0; i< words.Length; i++){
            char[] w = words[i].ToCharArray();
            Array.Reverse(w);
            words[i] = new string(w);
        }

        return string.Join(" ", words);
    }
}