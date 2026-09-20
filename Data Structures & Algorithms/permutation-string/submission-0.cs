public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        int matches = 0;
        for (int i = 0; i < 26; i++) {
            if (s1Count[i] == s2Count[i]) {
                matches++;
            }
        }

        if (matches == 26) return true;

        int left = 0;
        for (int right = s1.Length; right < s2.Length; right++) {
            int rightIdx = s2[right] - 'a';
            if (s1Count[rightIdx] == s2Count[rightIdx]) {
                matches--;
            }
            s2Count[rightIdx]++;
            if (s1Count[rightIdx] == s2Count[rightIdx]) {
                matches++;
            }

            int leftIdx = s2[left] - 'a';
            if (s1Count[leftIdx] == s2Count[leftIdx]) {
                matches--;
            }
            s2Count[leftIdx]--;
            if (s1Count[leftIdx] == s2Count[leftIdx]) {
                matches++;
            }

            left++;

            if (matches == 26) return true;
        }

        return false;
    }
}