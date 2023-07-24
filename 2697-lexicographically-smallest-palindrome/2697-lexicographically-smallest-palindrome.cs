public class Solution {
    public string MakeSmallestPalindrome(string s) {
        StringBuilder sb = new StringBuilder(s);
        for ( int i = 0, j = s.Length-1; i < sb.Length/2; i++, j-- ) {

            if (s[i] > s[j] && s[i] != s[j])
            {
                sb[i] = s[j];
            }
            else
            {
                sb[j] = s[i];
            }
        }

        return sb.ToString();
    }
}