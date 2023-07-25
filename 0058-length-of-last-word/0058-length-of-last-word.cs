public class Solution {
    public int LengthOfLastWord(string s) {
        string[] splitedStr = s.Trim().Split(' ');
        return splitedStr[splitedStr.Length - 1].Length;
    }
}