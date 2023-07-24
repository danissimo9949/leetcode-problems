public class Solution {
    public int MaxDepth(string s) {
        List<int> maxNestedParenthenses = new List<int>();
        int parenthenses = 0;

        for ( int i = 0; i < s.Length; i++ )
        {
            if (s[i] == '(')
            {
                maxNestedParenthenses.Add(++parenthenses);
            }
            else if (s[i] == ')')
            {
                 maxNestedParenthenses.Add(--parenthenses);
            }
        }
        if (maxNestedParenthenses.Count != 0)
        {
            return maxNestedParenthenses.Max();
        }
        return 0;
    }
}