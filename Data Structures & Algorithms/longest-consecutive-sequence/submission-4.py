class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        n = set(nums)
        longest_streak = 0

        for num in n: 
            if (num - 1) not in n:
                current_num = num 
                current_streak = 1

                while (current_num + 1) in n: 
                    current_streak += 1 
                    current_num += 1
            
                longest_streak = max(longest_streak, current_streak)

        return longest_streak
            





