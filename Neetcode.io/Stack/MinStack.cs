public class MinStack {
    // again usage of simple stack understand the question first 
    // time complexity = o(1) space =o(n)
    Stack<(int val ,int minval)> stack;
    int minval= int.MaxValue;
    public MinStack() {
        stack = new Stack<(int ,int)>();
    }
    
    public void Push(int val) {
        minval = Math.Min(val,minval);
        stack.Push((val,minval));
    }
    
    public void Pop() {
        stack.Pop();
        if(stack.Count >0){
            minval = stack.Peek().minval;
        }
        else{
            minval =int.MaxValue;
        }
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().minval;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */