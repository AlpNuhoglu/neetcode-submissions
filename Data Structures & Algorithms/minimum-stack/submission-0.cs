public class MinStack {
    private List<int> mainStack; 
    private List<int> minStack; 

    public MinStack() {
        mainStack = new List<int>(); 
        minStack = new List<int>(); 
    }
    
    public void Push(int val) {
        mainStack.Add(val); 

        if (minStack.Count == 0) {
            minStack.Add(val); 
        } else {
            int previousMin = minStack[minStack.Count - 1]; 
            int currentMin = Math.Min(previousMin, val); 
            minStack.Add(currentMin); 
        }
    }
    
    public void Pop() {
        int lastIndex = mainStack.Count - 1; 
        mainStack.RemoveAt(lastIndex); 
        minStack.RemoveAt(lastIndex); 
    }
    
    public int Top() {
        return mainStack[mainStack.Count - 1]; 
    }
    
    public int GetMin() {
        return minStack[minStack.Count - 1]; 
    }
}
