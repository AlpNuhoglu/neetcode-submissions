public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> seen = new Dictionary<string, List<string>>(); 

        for (int i = 0; i < strs.Length; i++) {
            string sorted = string.Concat(strs[i].OrderBy(c => c));  

            if (seen.TryGetValue(sorted, out List<string> group)) {
                group.Add(strs[i]); 
                continue; 
            }

            List<string> temp = new();
            temp.Add(strs[i]); 
            seen.Add(sorted, temp); 
        }

        return new List<List<string>>(seen.Values); 
    }
}
