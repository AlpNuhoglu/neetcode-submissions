class Solution:
    def isPalindrome(self, s: str) -> bool:
        left = 0
        right = len(s) - 1 

        while left < right: 
            while (left < right and s[left].isalnum() != True): left += 1
            while (left < right and s[right].isalnum() != True): right -= 1


            if s[left].upper() != s[right].upper(): 
                return False 
            left += 1 
            right -= 1 
        
        return True 