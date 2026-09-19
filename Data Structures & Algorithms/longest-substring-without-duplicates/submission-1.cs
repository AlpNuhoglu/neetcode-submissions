public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length; 
        if (s == null || n == 0) return 0; 
        if (n == 1) return 1; 

        Dictionary<char, int> seen = new Dictionary<char, int>(); 
        int left = 0; 
        int right = 1; 

        seen[s[left]] = 0; 
        int maxLength = 0; 

        while (right < n) 
        {
            if (seen.TryGetValue(s[right], out var matchingIndex)) {
                int temp = matchingIndex - left; 
                left = Math.Max(matchingIndex + 1, left++); 
                seen.Remove(s[right]); 
            } 
            maxLength = Math.Max(maxLength, right - left + 1); 
            seen[s[right]] = right;
            right++; 
        }

        return maxLength;
    }
}
