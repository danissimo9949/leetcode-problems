public class Solution {
    public string ReverseWords(string s) {
        StringBuilder sb = new StringBuilder();
        string[] result = s.Split(' ');

        foreach (string word in result)
        {
            char[] reverse = word.Reverse().ToArray();

            for ( int i = 0; i < reverse.Length; i++ )
            {
                sb.Append(reverse[i]);
            }

            sb.Append(" ");
        }

        return sb.ToString().Trim();
    }
}