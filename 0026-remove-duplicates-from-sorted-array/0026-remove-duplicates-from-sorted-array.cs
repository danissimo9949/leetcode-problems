public class Solution {
   public int RemoveDuplicates(int[] nums) {
      int result = 1;

      for (int i = 0; i < nums.Length-1; i++)
      {
         if (nums[i] != nums[i + 1])
         {
            nums[result] = nums[i+1];
            result++;
         }
      }
      return result; 
   }
}