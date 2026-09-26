public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        int openN = 0; 
        int closedN = 0;
        string stack = ""; 

        var result = new List<string>(); 

        Dfs(openN, closedN, n, stack, result);
        return result; 
        
    }  
    public void Dfs(int openN, int closedN, int n, string stack, List<string> result) 
    {
        if (openN == closedN && openN == n) {
            result.Add(stack); 
            return; 
        }

        if (openN < n) {
            stack += '('; 
            Dfs(openN + 1, closedN, n, stack, result); 
            stack = stack.Remove(stack.Length - 1);
        } 
        
        if (closedN < openN){
            stack += ')'; 
            Dfs(openN, closedN + 1, n, stack, result); 
        }

    }

}
