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
                        switch (token) {
                            case "+": 
                                int temp2 = stack.Pop(); 
                                int temp1 = stack.Pop(); 
                                stack.Push(temp1 + temp2); 
                                break; 
                            case "-":
                                int temp3 = stack.Pop(); 
                                int temp4 = stack.Pop(); 
                                stack.Push(temp4 - temp3); 
                                break; 
                            case "*": 
                                int temp5 = stack.Pop(); 
                                int temp6 = stack.Pop(); 
                                stack.Push(temp6 * temp5); 
                                break; 
                            case "/": 
                                int temp7 = stack.Pop(); 
                                int temp8 = stack.Pop(); 
                                stack.Push(temp8 / temp7); 
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
