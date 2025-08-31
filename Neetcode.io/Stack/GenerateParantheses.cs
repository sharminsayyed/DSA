public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        // Pattern: Backtracking + Stack.
        // time complexity =  O(4^n / √n) space =O(n)
        // only add parantheses if open < n
        // only add closing parantheses if closed <open
        // valid if opne == close == n
        
        var res = new List<string>();
        var s = new StringBuilder();
        BackTrack(res ,s,0,0,n);
        return res;
    }
    private void BackTrack(List <string> res ,StringBuilder s ,int open ,int close,int n){
           if(open ==n && close ==n){
            res.Add(s.ToString());
            return;
           }
        // 1)s.Append('(') → we try adding '('.
        // 2)Then we recurse down that path.
        // 3)When recursion comes back, we don’t want to keep that '(' forever, because now we want to explore other choices (like adding ')').
        
           if(open < n){
            s.Append('(');
            BackTrack(res ,s, open+1,close,n);
            s.Length--;
           }
           if(close <open){
            s.Append(')');
            BackTrack(res ,s,open,close+1,n);
            s.Length--;
           }
        }
}