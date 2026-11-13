class Solution:
    def pacificAtlantic(self, heights: List[List[int]]) -> List[List[int]]:
        ROW, COL = len(heights), len(heights[0])
        pac, atl = set(), set()


        def dfs(r, c, ocean, prevHeight):
            if (r < 0 or c < 0 or COL <= c or ROW <= r or 
                (r, c) in ocean or heights[r][c] < prevHeight): 
                return 

            ocean.add((r, c))
            dfs(r + 1, c, ocean, heights[r][c])
            dfs(r - 1, c, ocean, heights[r][c])
            dfs(r, c + 1, ocean, heights[r][c])
            dfs(r, c - 1, ocean, heights[r][c])
        
        for c in range(COL):
            dfs(0, c, pac, heights[0][c])
            dfs(ROW - 1, c, atl, heights[ROW - 1][c])
        
        for r in range(ROW): 
            dfs(r, 0, pac, heights[r][0])
            dfs(r, COL - 1, atl, heights[r][COL - 1])
        
        res = []
        for c in range(COL): 
            for r in range(ROW): 
                if (r, c) in pac and (r, c) in atl:
                    res.append([r, c])
        return res