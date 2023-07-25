public class Solution {
    public int LengthOfLongestSubstring(string s) {
        List<char> invastigatedSymbols = new List<char>();
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (invastigatedSymbols.Contains(s[i]))
            {
                int index = invastigatedSymbols.IndexOf(s[i]) + 1;
                invastigatedSymbols.RemoveRange(0,index);
            }
            invastigatedSymbols.Add(s[i]);
            maxLength = Math.Max(maxLength, invastigatedSymbols.Count);
            
        }
        return maxLength;
    }
}