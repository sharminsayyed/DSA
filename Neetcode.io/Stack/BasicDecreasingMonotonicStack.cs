public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        // here we store the decreasing monotonic stack
        // time complexity =O(2n) space =O(n)
        int n = nums.Length;
        int[] nge = new int[n];
        var stack = new Stack<int>();
        for(int i = n-1 ;i >=0 ;i--){
            while(stack.Count >0 && stack.Peek() <= nums[i]){
                stack.Pop();
            }
            if(stack.Count == 0){
                nge[i] =-1;
            }
            else{
                nge[i] = stack.Peek();
            }
            stack.Push(nums[i]);

        }
        return nge;

    }
}