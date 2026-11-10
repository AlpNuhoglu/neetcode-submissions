class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        res = []
       
        def dfs(current_sum, i, subset):
            if current_sum == target: 
                res.append(subset.copy()) 
                return
            if i >= len(nums) or current_sum > target: 
                return
            
            subset.append(nums[i])
            dfs(current_sum + nums[i], i, subset)
            subset.pop()

            dfs(current_sum, i + 1, subset)

        dfs(0, 0, [])
        return res