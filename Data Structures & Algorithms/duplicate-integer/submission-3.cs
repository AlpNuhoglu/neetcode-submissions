public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length; 

        Dictionary<int, int> myDic = new Dictionary<int, int>(); 

        for (int i = 0; i < n; i++) 
        {
            if(myDic.ContainsValue(nums[i])) return true; 

            myDic.Add(i, nums[i]); 

        } 
        return false; 

    }
}