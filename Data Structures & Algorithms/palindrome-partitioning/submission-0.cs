public class Solution {
    public List<List<string>> Partition(string s) {

        var res = new List<List<string>>(); 
        var subset = new List<string>(); 

        Dfs(s, 0, subset, res); 
        return res; 
    }

    public void Dfs(string s, int i, List<string> subset, List<List<string>> res){
        if (i >= s.Length) {
            res.Add(new List<string> (subset)); 
            return;
        }

        for (int j = i; j < s.Length; j++) {
            if (isPali(s, i, j)) {
                subset.Add(s.Substring(i, j - i + 1)); 
                Dfs(s, j + 1, subset, res);
                subset.RemoveAt(subset.Count - 1); 
            }
        }
    }

    public bool isPali(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]) {
                return false; 
            } 
            left++; 
            right--; 
        }
        return true; 

    }


}
