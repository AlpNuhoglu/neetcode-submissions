class Solution:
    def canJump(self, nums: List[int]) -> bool:
        dp = [False] * len(nums)
        dp[0] = True 

        for i, num in enumerate(nums):
            if dp[i] == False: continue 
            for j in range(i, (i + num + 1) if (i + num + 1) < len(nums) else len(nums)):
                dp[j] = True 

        return dp[-1]
        

