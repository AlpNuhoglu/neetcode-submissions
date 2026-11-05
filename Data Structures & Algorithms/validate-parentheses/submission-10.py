class Solution:
    def isValid(self, s: str) -> bool: 
        stack = []
        mapping = {')': '(', ']': '[', '}': '{'}

        for ch in s: 
            if ch == '(' or ch == '{' or ch == '[': 
                stack.append(ch)
            else:
                if not stack or mapping[ch] != stack[-1]: 
                    return False

                stack.pop()

        return len(stack) == 0 