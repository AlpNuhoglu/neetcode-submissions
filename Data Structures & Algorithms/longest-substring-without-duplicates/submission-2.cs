public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0; 

        int[] lastPosition = new int[256]; 
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++) {

            left = Math.Max(left, lastPosition[s[right]]);

            maxLength = Math.Max(maxLength, right - left + 1);

            lastPosition[s[right]] = right + 1;
        }

        return maxLength;
    }
}
