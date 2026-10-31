class Solution:
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        n = len(temperatures) 
        res = [0] * n
        stack = []
         
        for i, temperature in enumerate(temperatures):
            while stack and temperatures[stack[-1]] < temperature: 
                prevIndex = stack.pop() 
                res[prevIndex] = i - prevIndex

            stack.append(i)

        return res

