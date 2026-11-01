class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        n = len(nums)

        expected_sum = n * (n + 1) // 2
        current_sum = 0

        for num in nums: 
            current_sum += num 
        
        if current_sum != expected_sum: 
            return expected_sum - current_sum
        
        return 0


