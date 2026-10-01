public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        Array.Sort(piles); 

        int l = 1; 
        int r = piles.Max(); 
        int minNumber = int.MaxValue;  

        while (l <= r) {
            int k = (r + l) / 2; 
            int totalHour = 0; 


            foreach (var p in piles) {
                int currNumber = (int)(Math.Ceiling((double)p / k)); 
                totalHour += currNumber; 
            }

            if (h < totalHour) {
                l = k + 1; 
            } else {
                minNumber = Math.Min(minNumber, k); 
                r = k - 1;
            }

        }
        return minNumber; 

    }
}
