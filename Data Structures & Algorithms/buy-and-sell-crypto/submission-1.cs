public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int n = prices.Length; 
        if (n == 1) return 0; 

        int left = 0; 
        int right = 1; 
        int maxProfit = 0; 
        
        while (right < n) 
        {
            if (prices[left] < prices[right] && right < n) 
            {
                maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);  
            } else {
                left = right; 
            }
            right++;

        }
        
        return maxProfit; 

    }
}
