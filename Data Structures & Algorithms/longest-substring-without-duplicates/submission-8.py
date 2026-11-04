class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if len(s) == 0: return 0

        longest_streak = 1
        start_index = 0
        seen = {}

        for i, ch in enumerate(s): 
            if ch in seen:
                start_index = max(start_index, seen[ch] + 1)
                
            current_streak = i - start_index + 1 
            longest_streak = max(longest_streak, current_streak)
            
            seen[ch] = i 
        
        return longest_streak
