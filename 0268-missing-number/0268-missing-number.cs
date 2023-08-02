public class Solution {
    public int MissingNumber(int[] nums) {
        int expectedSum = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                expectedSum += i;
            }
            int currentSum = nums.Sum();
            
            return expectedSum - currentSum;
    }
}