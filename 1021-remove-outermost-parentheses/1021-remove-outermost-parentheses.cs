
public class Solution {
    public string RemoveOuterParentheses(string s) {
        
        StringBuilder sb = new StringBuilder();
            int counterOfOuterParentheses = 0;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    if (counterOfOuterParentheses > 0)
                    {
                        sb.Append(c);
                    }
                    counterOfOuterParentheses++;
                }
                else if (c == ')')
                {
                    counterOfOuterParentheses--;
                    if (counterOfOuterParentheses > 0) {
                        sb.Append(')');
                    }
                }
            }

            return sb.ToString();
    }
}