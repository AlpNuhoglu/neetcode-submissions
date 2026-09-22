public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length; 

        var cars = new (int pos, double time)[n]; 
        for (int i = 0; i < n; i++) {
            double time = (double)(target - position[i]) / speed[i]; 
            cars[i] = (position[i], time); 
        }

        Array.Sort(cars, (a, b) => b.pos.CompareTo(a.pos)); 

        int fleetCount = 0; 
        double maxTime = 0; 

        foreach (var car in cars) {
            if (car.time > maxTime) {
                fleetCount++; 
                maxTime = car.time; 
            }
        }
        return fleetCount; 

    }



}






