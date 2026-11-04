class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        seen = {}
        left, right = 0, 0 
        res = 0
        max_freq = 0

        while right < len(s): 
            seen[s[right]] = 1 + seen.get(s[right], 0)

            if max_freq < seen[s[right]]:
                max_freq = seen[s[right]]

            if (right - left + 1) - max_freq <= k: 
                res = max(res, right - left + 1) 
            else: 
                seen[s[left]] -= 1 
                left += 1 
            right += 1 
            
        
        return res


