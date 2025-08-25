public class Solution {
    public bool IsValid(string s) {
        // time complexity = O(n) space =O(n)
        // pattern - simple stack pattern using push and pop
        Stack<char> stack = new Stack<char>();
        foreach(char c in s ){
            if(c == '(' || c=='{' || c=='['){
                stack.Push(c);
            }
            else{
                // if no ele is present in the stack return false 
                if(stack.Count == 0) return false;
                // if ele is present than pop the last ele 
                char top = stack.Pop();
                // check if the matching brackets are present or not 
                if((c==')' && top != '(') || 
                    (c == '}' && top != '{') ||
                    (c==']' && top != '[')){
                        return false;
                    }

            }
        }
        // here it will return true if stck is empty
        return stack.Count == 0;
    }
}