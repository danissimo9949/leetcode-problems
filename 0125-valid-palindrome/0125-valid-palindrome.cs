public class Solution {
    public bool IsPalindrome(string s) {
        string res = new string(s.ToLower()
                .Replace(" ", "")
                .Where(c => !char.IsPunctuation(c) 
                 && !char.IsSymbol(c))
                .ToArray());

            Console.WriteLine(res);
            for (int i = 0, j = res.Length - 1; i < res.Length/2; i++, j--)
            {
                if (char.IsPunctuation(res[i]))
                    i++;

                if (char.IsPunctuation(res[j]))
                    j--;

                if (!(res[i] == res[j]))
                    return false;
            }
            
          
            return true;
    }
}