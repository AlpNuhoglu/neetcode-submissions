class Solution:
    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        intervals = sorted(intervals)
        res = []

        res.append(intervals[0])

        for interval in intervals: 
            if interval[0] < res[-1][1] and interval[1] <= res[-1][1]: 
                continue 
            elif interval[0] <= res[-1][1]: 
                res[-1][1] = max(res[-1][1], interval[1])
            else: 
                res.append(interval) 
        
        return res 