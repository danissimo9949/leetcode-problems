public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        HashSet<string> distinctCombinations = new HashSet<string>();
        string[] morzeAlphabet = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
                "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        foreach (string word in words)
        {
            string representWord = "";
            foreach (char letter in word)
            {
                int index = letter - 'a';
                representWord += morzeAlphabet[index];
            }
            distinctCombinations.Add(representWord);
        }

        return distinctCombinations.Count();
    }
}