public class Solution {
    public List<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return []; 
        
        var map = new Dictionary<char, string> {
            {'2', "abc"}, {'3', "def"}, {'4', "ghi"},
            {'5', "jkl"}, {'6', "mno"}, {'7', "pqrs"},
            {'8', "tuv"}, {'9', "wxyz"}
        };

        var result = new List<string>(); 
        Backtrack(digits, 0, "", map, result); 
        return result; 
    }

    public void Backtrack(string digits, int index, string current, Dictionary<char, string> map, List<string> result) {
        if (index >= digits.Length) {
            result.Add(current); 
            return; 
        }

        var letters = map[digits[index]]; 

        foreach (var letter in letters) {
            Backtrack(digits, index + 1, current + letter, map, result); 
        }

    }

}
