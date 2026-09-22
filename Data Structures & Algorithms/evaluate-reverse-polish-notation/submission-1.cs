public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens == null || tokens.Length == 0) return 0; 

        Stack<int> stack = new Stack<int>(); 

        foreach (var token in tokens) {
            if (token == "+" || token == "-" 
                || token == "*" || token == "/") {
                    if (stack.Count < 2) {
                        return 0; 
                    } else {
                        int right = stack.Pop(); 
                        int left = stack.Pop(); 
                        switch (token) {
                            case "+": 
                                stack.Push(left + right); 
                                break; 
                            case "-":
                                stack.Push(left - right); 
                                break; 
                            case "*": 
                                stack.Push(left * right); 
                                break; 
                            case "/": 
                                stack.Push(left / right); 
                                break; 
                        }
                    }
            } else {
                stack.Push(int.Parse(token)); 
            }
        }

        return stack.Pop(); 
    }
}
