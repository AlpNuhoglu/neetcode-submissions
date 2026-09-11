public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length; 

        HashSet<int> seq = new HashSet<int>(); 
        foreach(int num in nums) {
            seq.Add(num); 
        }

        int counter = 0; 
        foreach(int num in seq) {
            if (seq.Contains(num - 1)) continue; 

            int temp = 1; 
            int curr = num; 
            while (seq.Contains(curr + 1)) {
                curr++;
                temp++; 
            } 

            if (temp > counter) counter = temp; 
        }

        return counter; 



    }
}
