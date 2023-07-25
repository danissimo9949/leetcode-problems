public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        
        return names.Zip(heights).OrderByDescending(height => height.Second).Select(x => x.First).ToArray();
    }
}