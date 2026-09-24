public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length; 

        Array.Sort(position, speed);

        int fleetNumber = 0; 
        double maxTime = 0; 

        for (int i = n - 1; 0 <= i; i--) {
            double currentTime = (double)(target - position[i]) / speed[i];

            if (maxTime < currentTime) {
                fleetNumber++; 
                maxTime = currentTime; 
            }
        }
        return fleetNumber; 
    }



}






