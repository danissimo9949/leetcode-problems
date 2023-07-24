public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int countOfConsistent = 0;

        foreach (string word in words)
        {
            int countOfOccurence = 0;
            foreach (char letter in word)
            {
                if (!allowed.Contains(letter))
                {
                    break;
                }
                countOfOccurence++;
            }
            if (countOfOccurence == word.Length)
            {
                countOfConsistent++;
            }
        }
        return countOfConsistent;
    }
}