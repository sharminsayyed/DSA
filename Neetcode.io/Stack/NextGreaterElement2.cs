public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        // time complexity =O(4n) space =O(2n)
        //watch striver videro nge 1 and nge 2
        // here we store the decreasing monotonic stack
        int n = nums.Length;
        int[] nge = new int[n];
        var stack = new Stack<int>();
        for(int i = 2*n-1 ;i >=0 ;i--){
            while(stack.Count >0 && stack.Peek() <= nums[i%n]){
                stack.Pop();
            }
            // here it means we need to generate the nge ele for the ele in nums 
            if(i<n){
                nge[i] = stack.Count == 0 ? -1 : stack.Peek();
            }
            stack.Push(nums[i%n]);

        }
        return nge;

    }
}