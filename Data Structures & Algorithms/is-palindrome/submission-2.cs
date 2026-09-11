public class Solution {
    public bool IsPalindrome(string s) {
        if (s == null) return false; 

        int start = 0; 
        int end = s.Length - 1; 

        while (start < end) {
    
            while (start < end && !char.IsLetterOrDigit(s[start])) start++; 

            while (start < end && !char.IsLetterOrDigit(s[end])) end--; 

            if (char.ToUpperInvariant(s[start]) != char.ToUpperInvariant(s[end])) {
                return false; 
            }


            start++; 
            end--; 
        }

        return true; 
    }

}
