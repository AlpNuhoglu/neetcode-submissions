public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> group = new List<List<int>>(); 

        for (int i = 0; i < nums.Length - 2; i++) 
        {
            if (nums[i] > 0) break;
            if (i != 0 && nums[i] == nums[i - 1]) continue; 

            int left = i + 1; 
            int right = nums.Length - 1;

            while (left < right) { 
                if (nums[left] + nums[right] + nums[i] == 0) {
                    group.Add([nums[i], nums[left], nums[right]]); 
                    left++; 
                    right--; 
                    
                    while (left < right && nums[left] == nums[left - 1]) left++;    
                    while (left < right && nums[right] == nums[right + 1]) right--; 

                } else if (nums[left] + nums[right] + nums[i] > 0) {
                    right--;
                } else {
                    left++; 
                }
            }
        }

        return group;

    }
}
