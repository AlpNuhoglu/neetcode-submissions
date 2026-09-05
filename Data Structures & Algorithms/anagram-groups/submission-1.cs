public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>(); 

        foreach(string str in strs) {
            int[] count = new int[26]; 

            foreach(char c in str) {
                count[c - 'a']++; 
            }
        

            StringBuilder keyBuilder = new StringBuilder(); 
            for (int i = 0; i < 26; i++) {
                keyBuilder.Append('#'); 
                keyBuilder.Append(count[i]); 
            }

            string key = keyBuilder.ToString(); 


            if (!map.TryGetValue(key, out var group)) {
                group = new List<string>(); 
                map[key] = group; 
            }

            group.Add(str);
        }

        return new List<List<string>>(map.Values); 
    }
}
