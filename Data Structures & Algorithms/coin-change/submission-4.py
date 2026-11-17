class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        memo = {}

        def dfs(i, curr):
            if (i, curr) in memo: 
                return memo[(i,curr)]

            if curr == amount:

                return 0 
            if i >= len(coins) or curr > amount: 
                return float('inf')

            take = 1 + dfs(i, curr + coins[i])
            skip = dfs(i + 1, curr)

            memo[(i,curr)] = min(take, skip)
            return memo[(i,curr)]
        
        ans = dfs(0,0)
        return ans if ans != float('inf') else -1