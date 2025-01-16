/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

// in place reversal pattern 
// time complexity = O(n) and space = O(1)
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        if (head == null || left == right )
            return head ;
        
        // create a dummy node if left =1 
        ListNode dummy = new ListNode(0);
        dummy.next =head ;

        // node before left position which will be used for further connnection
        ListNode beforeleft = dummy ;
        for (int i =0; i< left-1; i++){
            beforeleft = beforeleft.next;
        }


        // assigining the currentnode /leftnode , prevnode ,nextnode 
        ListNode current = beforeleft.next;
        ListNode leftnode = current;
        ListNode prev =null,next =null;
        // looping only that segment which we have to reverse right-left iterations only 
        for(int i=0; i<= right-left; i++ ){
            next = current.next;
            current.next = prev;
            prev = current;
            current =next;
        }

        // joining the pieces 
        beforeleft.next = prev;
        leftnode.next = current;

        return dummy.next;
    }
}