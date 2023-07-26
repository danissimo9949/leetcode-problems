public class Solution {
    public int StrStr(string haystack, string needle) {
        if (!haystack.Contains(needle)){
            return -1;
        } else{
            return haystack.IndexOf(needle);
        }
    }
}