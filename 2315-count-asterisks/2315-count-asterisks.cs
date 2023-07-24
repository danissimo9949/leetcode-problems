public class Solution {
    public int CountAsterisks(string s) {
        int countAsterisks = 0;

            string[] pairs = s.Split('|');

            for (int i = 0; i < pairs.Length; i+=2 ) { 

                foreach (char symbol in pairs[i])
                {
                    if ( symbol == '*')
                    {
                        countAsterisks++;
                    }
                }
            }
            return countAsterisks;
    }
}