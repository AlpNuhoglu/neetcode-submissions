class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        currentSum = 0
        hashmap = {0: 1}
        res = 0

        for num in nums: 
            currentSum += num 
            diff = currentSum - k 

            res += hashmap.get(diff, 0)
            hashmap[currentSum] = 1 + hashmap.get(currentSum, 0)
        
        return res
