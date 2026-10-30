class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        hashset = set(nums)
        longestCons = 0

        for i, num in enumerate(hashset):
            if (num - 1) not in hashset: 
                currentSum = 1
                while (num + 1) in hashset:
                    currentSum += 1 
                    i += 1
                    num += 1
                longestCons = max(longestCons, currentSum)
        
        return longestCons