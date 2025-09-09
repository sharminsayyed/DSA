public class Solution {
    public int Search(int[] nums, int target) {
        // time complexity =O(nlog)
        int left = 0; 
        int right = nums.Length -1;
        while(left <= right){
            int mid = left +(right-left)/2; // prevents overfl
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] < target)
                left = mid+1; // move left towards right
            else if(nums[mid] > target)
                right = mid-1; // move right towards left 
        }
        return -1;
    }
}