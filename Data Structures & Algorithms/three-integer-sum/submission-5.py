class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums = sorted(nums)
        res = []

        for i in range(len(nums)):
            while i > 0 and i < len(nums) - 1 and nums[i - 1] == nums[i]: i += 1
            seen = set()
            target = nums[i] * -1

            for n in nums[i + 1:]:
                complement = target - n 
                if complement in seen:
                    temp_result = [nums[i], complement, n]
                    if temp_result not in res:  
                        res.append(temp_result)

                seen.add(n)

        return res