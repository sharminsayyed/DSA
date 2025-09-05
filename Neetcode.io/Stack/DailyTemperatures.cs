public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // time complexity = o(n) space =o(n)
        //Pattern: Monotonic Decreasing Stack.
        // when we store ele in stack in specific order(increasing ,decreasing ,other ) - monotonic stack
        //https://github.com/sharminsayyed/DSA/blob/main/Neetcode.io/Stack/BasicDecreasingMonotonicStack.cs
        int n = temperatures.Length;
        int [] ngeind = new int[n]; // next greater ele index 
        var stack = new Stack<int>();
        // decreasing monotonic stack - starting from right/last index
        for(int i= n-1; i>= 0; i--){
            while(stack.Count >0 && temperatures[stack.Peek()] <= temperatures[i]){
                stack.Pop();
            }

            ngeind[i] = stack.Count ==0 ? 0:stack.Peek()-i;

            stack.Push(i);
        }
        return ngeind;
    }
}