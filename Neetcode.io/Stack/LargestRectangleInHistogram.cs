public class Solution {
    public int LargestRectangleArea(int[] heights) {
        // time complexity = O(3n)=O(n) space =O(n)
        int n = heights.Length;
        int maxarea = 0; // To store the maximum area found
        var stack = new Stack<int>(); // we store index of the height in the stack
        // increasing monotonic stack 
        for(int i = 0;i<= n;i++){
            // // If we are at the end, set currentHeight to 0 to pop remaining bars
            int currheight = (i == n) ? 0: heights[i];
            // If current height is smaller than the last one in stack, pop and calculate area
            while(stack.Count >0 && currheight <= heights[stack.Peek()])
            {
                int h = heights[stack.Pop()]; // get the height of the top of the stack and pop it 
                // Calculate the width for the rectangle
                // If stack is empty, it stretches from start (0) to i
                // Otherwise, it stretches between bars in the stack 
                int w = stack.Count == 0? i : i-stack.Peek() -1; 
                maxarea = Math.Max(maxarea , h*w); // compare
            }
            // Push the current height index into the stack
            stack.Push(i); 
        }
        return maxarea; // return the max area found
    }
}