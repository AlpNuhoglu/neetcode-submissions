public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        string sortedS = string.Concat(s.OrderBy(c => c)); 
        string sortedT = string.Concat(t.OrderBy(c => c)); 

        return sortedS == sortedT; 

    }
}
