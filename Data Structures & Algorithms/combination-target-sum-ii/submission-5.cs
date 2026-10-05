public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates); 

        var result = new List<List<int>>(); 
        var subset = new List<int>(); 

        Dfs(candidates, 0, target, 0, subset, result);
        return result; 
    }   

    public void Dfs(int[] candidates, int i, int target, int currentSum, List<int> subset, List<List<int>> res) 
    {
        if (currentSum == target) {
            res.Add(new List<int> (subset));  
            return; 
        }


        if (currentSum > target || i >= candidates.Length) {
            return; 
        }

        subset.Add(candidates[i]);
        Dfs(candidates, i + 1, target, currentSum + candidates[i], subset, res); 
        subset.RemoveAt(subset.Count - 1); 

        while (i < candidates.Length - 1 && candidates[i] == candidates[i + 1]) {
            i++; 
        }

        Dfs(candidates, i + 1, target, currentSum, subset, res); 

    }
}
