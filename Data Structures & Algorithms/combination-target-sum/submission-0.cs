public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {    
        var res = new List<List<int>>(); 
        var subset = new List<int>(); 
        Dfs(nums, 0, target, 0, subset, res); 
        return res; 
    }

    public void Dfs(int[] nums, int i, int target, int currentSum, List<int> subset,
    List<List<int>> res) 
    {
        if (currentSum == target) {
            res.Add(new List<int>(subset));
            return;  
        }

        if (currentSum > target || i >= nums.Length) {
            return; 
        }

        subset.Add(nums[i]); 
        Dfs(nums, i, target, currentSum + nums[i], subset, res); 

        subset.RemoveAt(subset.Count - 1); 
        Dfs(nums, i + 1, target, currentSum, subset, res);    

    
    }


}