public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for ( int i = m, j = 0; i < nums1.Length; i++, j++ )
        {
            nums1[i] = nums2[j];
        }
        Array.Sort(nums1);  
    }
}