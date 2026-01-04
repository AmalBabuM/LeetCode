public class Solution
{
    public string RemoveDuplicates(string s)
    {
        Stack<char> st = new();

        foreach (char c in s)
        {
            if (st.TryPeek(out char d) && d == c)
            {
                st.Pop();
                continue;
            }

            st.Push(c);
        }

        return string.Concat(st.Reverse());
    }
}