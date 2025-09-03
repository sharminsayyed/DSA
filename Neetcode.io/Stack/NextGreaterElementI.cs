public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) { 
        // time complexity = O(n+m)space =O(m)
        // when we store ele in stack in specific order(increasing ,decreasing ,other ) - monotonic stack
        // normal monostatic stack (where we store the ele and its next greater ele in the dictionary)
        if (nums1 == null || nums1.Length == 0){
            return new int[0];
        }
        var stack = new Stack<int>(); // keep count and compare ele 
        var dict = new Dictionary<int ,int>(); // to store ele -> next greater ele in nums2
        foreach(var num in nums2){
            while(stack.Count() > 0 && stack.Peek() < num){
                // popped ele -> next greater ele 
                // 1->3 popped ele -> number 
                dict.Add(stack.Pop(),num);
            }
            stack.Push(num);
        }

// match the dictinary with nums1 so we get to see only the ele which are duplicate in nums1 and nums 2 
// they checked on nums1 
        var res = new int[nums1.Length];
        for(int i= 0;i <nums1.Length; i++){
            res[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] :-1;
        }
        return res;
        
    }
}