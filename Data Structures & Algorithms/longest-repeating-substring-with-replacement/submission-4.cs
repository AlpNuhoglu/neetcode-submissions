public class Solution {
    public int CharacterReplacement(string s, int k) {
        if (string.IsNullOrEmpty(s)) return 0; 

        var seen = new Dictionary<char, int>(26); 
        int maxLength = 0; 
        int left = 0; 
        int maxFrequency = 0; 

        for (int right = 0; right < s.Length; right++) {
            int windowLength = right - left + 1; 
            if (!seen.TryGetValue(s[right], out var value)) {
                seen[s[right]] = 0; 
            } 
            
            seen[s[right]]++; 
            maxFrequency = Math.Max(maxFrequency, seen[s[right]]); 

            if (windowLength - maxFrequency > k) {
                seen[s[left]]--;
                left++; 
            } else {
                maxLength = Math.Max(maxLength, windowLength); 
            }
        }

        return maxLength; 
    }
}
