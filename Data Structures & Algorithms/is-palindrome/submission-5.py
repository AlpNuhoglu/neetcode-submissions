class Solution:
    def isPalindrome(self, s: str) -> bool:
        left = 0
        right = len(s) - 1

        s = s.upper()

        while left < right: 
            if s[left].isalnum() == True and s[right].isalnum() == True:
                if s[left] != s[right]: 
                    return False 
                left += 1
                right -= 1
            else: 
                while (left < right and s[left].isalnum() == False): left += 1
                while (left < right and s[right].isalnum() == False): right -= 1

        return True
