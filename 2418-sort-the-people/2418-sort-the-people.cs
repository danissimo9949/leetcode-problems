public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        
        string[] sortedPeople = new string[names.Length];
        int index = 0;

        SortedDictionary<int,string> table = new SortedDictionary<int,string>();

        for (int i = 0; i < names.Length; i++)
        {
            table.Add(heights[i], names[i]);
        }

        foreach (var person in table)
        {
            sortedPeople[index++] = person.Value;
        }

        Array.Reverse(sortedPeople);
        return sortedPeople;
    }
}