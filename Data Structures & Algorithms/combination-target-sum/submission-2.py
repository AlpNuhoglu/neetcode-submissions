class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        res = []
        subset = []

        def dfs(current_sum, i):
            if current_sum == target: 
                if subset not in res: 
                    res.append(subset.copy()) 
            
            if i >= len(nums) or current_sum > target: 
                return
            
            subset.append(nums[i])
            dfs(current_sum + nums[i], i)
            subset.pop()

            dfs(current_sum, i + 1)

        dfs(0, 0)
        return res