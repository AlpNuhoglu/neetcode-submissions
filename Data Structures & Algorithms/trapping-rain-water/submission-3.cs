public class Solution {
    public int Trap(int[] height) 
    {   
        if (height == null || height.Length < 3) return 0;

        int left = 0, right = height.Length - 1; 
        int maxLeft = 0, maxRight = 0; 
        int totalWater = 0;  

        while (left < right) 
        { 
            if (height[left] < height[right]) 
            {
                maxLeft = Math.Max(maxLeft, height[left]);
                totalWater += maxLeft - height[left];
                left++;
            } 
            else 
            {
                maxRight = Math.Max(maxRight, height[right]);
                totalWater += maxRight - height[right];
                right--;
            }
        }
        
        return totalWater; 
    }
}