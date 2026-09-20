public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length) {
            return string.Empty;
        }

        Span<int> tFreq = stackalloc int[128];
        Span<int> windowFreq = stackalloc int[128];

        int requiredMatches = 0;
        foreach (char c in t) {
            if (tFreq[c] == 0) requiredMatches++; 
            tFreq[c]++;
        }

        int formedMatches = 0;
        int left = 0;
        int minLength = int.MaxValue;
        int minStart = 0;

        for (int right = 0; right < s.Length; right++) {
            char rightChar = s[right];
            windowFreq[rightChar]++;

            if (tFreq[rightChar] > 0 && windowFreq[rightChar] == tFreq[rightChar]) {
                formedMatches++;
            }

            while (left <= right && formedMatches == requiredMatches) {
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    minStart = left;
                }

                char leftChar = s[left];
                windowFreq[leftChar]--;

                if (tFreq[leftChar] > 0 && windowFreq[leftChar] < tFreq[leftChar]) {
                    formedMatches--;
                }

                left++;
            }
        }

        return minLength == int.MaxValue ? string.Empty : s.Substring(minStart, minLength);
    }
}