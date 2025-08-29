public class Solution {
    public int EvalRPN(string[] tokens) {
        // time complexity =O(n) space =O(n)
        //Evaluate Reverse Polish Notation (RPN) is a classic stack-based expression evaluation problem.
        Stack<int> stack = new Stack<int>();
        foreach(string ch in tokens){
            // the ch is not a number then it will be the operators 
            if(ch=="+" || ch=="-" || ch=="*"|| ch=="/"){
                // get the top 2 elements from the stack so we can perfrom + ,-,*./
                int a = stack.Pop();
                int b =stack.Pop();
                int res =0;
                //so we can perfrom + ,-,*./
                //The topmost element is the last one pushed, so it is the right-hand operand (a).
                // The next element below it is the left-hand operand (b).
                switch(ch){
                    case "+" : res = b+a;
                                break;
                    case "-" : res = b-a;  
                                break;
                    case "*" : res = b*a;
                                break;    
                    case "/" : res = b/a;
                                break;
                }
                // push the result in the stack back 
                stack.Push(res);
            }
            else{
                // if it is a number like 4,5 ....
                // then push that number into the stack 
                stack.Push(int.Parse(ch));
            }
        }
        return stack.Pop();
    }
}