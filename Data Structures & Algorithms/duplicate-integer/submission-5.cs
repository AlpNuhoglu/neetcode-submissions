public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length; 

        HashSet<int> mySet = new HashSet<int>(); 

        for (int i = 0; i < n; i++) 
        {
            if (!mySet.Add(nums[i])) return true; 

        } 
        return false; 

    }
}