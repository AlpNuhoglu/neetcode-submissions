public class Solution {
    public int[] DailyTemperatures(int[] temperatures) 
    {
        int n = temperatures.Length;

        var stack = new Stack<int>(); 
        var result = new int[n]; 

        for (int i = 0; i < n; i++) {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]){
                int currentIdx = stack.Pop();

                result[currentIdx] = i - currentIdx; 
            }
            stack.Push(i); 
        }

        return result;
    }
}
