public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> seen = new Dictionary<int, int>(); 

        for (int i = 0; i < nums.Length; i++) {
            if (seen.ContainsKey(nums[i])) {
                int matchingKey = seen.FirstOrDefault(x => x.Key == nums[i]).Value;
                return [matchingKey, i];
            } 

            seen.Add(target - nums[i], i); 
        }
        return [0, 0]; 

    }
}
