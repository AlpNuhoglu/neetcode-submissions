public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> seen = new Dictionary<int, int>(); 

        for (int i = 0; i < nums.Length; i++) {
            if (seen.ContainsValue(nums[i])) {
                int matchingKey = seen.FirstOrDefault(x => x.Value == nums[i]).Key;
                return [matchingKey, i];
            } 

            seen.Add(i, target - nums[i]); 
        }
        return [0, 0]; 

    }
}
