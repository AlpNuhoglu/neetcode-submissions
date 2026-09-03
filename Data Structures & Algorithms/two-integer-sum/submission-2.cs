public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> seen = new Dictionary<int, int>(); 

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i]; 

            if (seen.TryGetValue(complement, out int matchingIndex)) {
                return new int[] {matchingIndex, i}; 
            }

            seen[nums[i]] = i; 
        }
        return new int[] {0, 0}; 

    }
}
