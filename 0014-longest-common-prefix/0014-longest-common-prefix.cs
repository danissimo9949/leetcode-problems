public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         if (strs.Length == 0)
                return "";
            if (strs.Length == 1)
                return strs[0];


            string firstWord = strs[0];
            int commonPrefixCount = firstWord.Length;

            for(int i = 1; i < strs.Length; i++)
            {
                int j = 0;

                while (j < commonPrefixCount && j < strs[i].Length && firstWord[j] == strs[i][j])
                {
                    j++;
                }

                commonPrefixCount = j;
            }

            return commonPrefixCount == 0 ? "" : firstWord.Substring(0, commonPrefixCount);
    }
}