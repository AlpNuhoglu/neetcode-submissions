public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var res = new List<List<int>>(); 
        var subset = new List<int>(); 
        var visited = new bool[nums.Length]; 

        Dfs(nums, visited, subset, res);
        return res; 
    }

    public void Dfs(int[] nums, bool[] visited, List<int> subset, List<List<int>> res) 
    {   
        if (subset.Count == nums.Length) {
            res.Add(new List<int>(subset)); 
            return; 
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (visited[i]) continue; 

            visited[i] = true; 
            subset.Add(nums[i]);

            Dfs(nums, visited, subset, res); 

            subset.RemoveAt(subset.Count - 1); 
            visited[i] = false; 
        }
    }
}
