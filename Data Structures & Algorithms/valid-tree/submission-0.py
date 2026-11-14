class Solution:
    def validTree(self, n: int, edges: List[List[int]]) -> bool:
        if not n: return True

        connMap = { i: [] for i in range(n)}

        for first, second in edges: 
            connMap[first].append(second)
            connMap[second].append(first)
            
        visitSet = set()
        def dfs(i, prev): 
            if i in visitSet: 
                return False 

            visitSet.add(i)
            for j in connMap[i]: 
                if j == prev: continue 
                if not dfs(j, i):
                    return False 
            return True 
        

        return dfs(0, -1) and n == len(visitSet)

        
