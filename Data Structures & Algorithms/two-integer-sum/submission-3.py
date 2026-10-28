class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        seen = {}
        res = []

        for i in range(len(nums)): 
            num = nums[i]
            complement = target - num 
            if complement in seen: 
                res.append(seen[complement])
                res.append(i)
                return res

            seen[num] = i

        return res
