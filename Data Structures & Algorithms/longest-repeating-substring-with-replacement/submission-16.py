class Solution:
    def characterReplacement(self, s: str, k: int) -> int: 
        left = 0
        max_length = 1
        max_freq = 1
        count = {}

        for right in range(len(s)): 
            count[s[right]] = 1 + count.get(s[right], 0)

            if max_freq < count[s[right]]: 
                max_freq = count[s[right]]
            
            current_length = right - left + 1 
            if current_length - max_freq <= k:
                max_length = max(max_length, current_length)
            else: 
                count[s[left]] -= 1
                left += 1 
        
        return max_length

            
        
            
