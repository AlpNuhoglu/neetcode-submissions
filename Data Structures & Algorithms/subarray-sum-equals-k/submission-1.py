class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        prefixSum = 0
        count = 0 
        hashmap = {prefixSum: count}
        res = 0

        hashmap[0] = 1

        for num in nums: 
            currentSum = prefixSum + num 
            if (currentSum - k) in hashmap: 
                res += hashmap[currentSum - k]
            
            prefixSum = currentSum 
            hashmap[prefixSum] = 1 + hashmap.get(prefixSum, 0)
        
        return res
