class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        freq = [[] for _ in range(len(nums) + 1)]

        for i, num in enumerate(nums): 
            count[num] = 1 + count.get(num, 0)
        
        for num, c in count.items(): 
            freq[c].append(num)

        result = []
        for i in range(len(nums), 0, -1):
            for num in freq[i]: 
                result.append(num) 
                if len(result) == k: 
                    return result 

        return result
            




        
        