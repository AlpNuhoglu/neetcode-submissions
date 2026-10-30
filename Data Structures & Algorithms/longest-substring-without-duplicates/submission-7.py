class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        hashmap = {}
        maxLength = 0
        startIndex = 0 

        for i, ch in enumerate(s): 
            if ch in hashmap: 
                startIndex = max(startIndex, hashmap[ch] + 1)

            hashmap[ch] = i 
            maxLength = max(maxLength, i - startIndex + 1)
        
        return maxLength