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
 // time complexity = O(n) space =O(1)
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null) return null;
        ListNode odd = head ; // assign odd to head  as 1st node is always odd
        ListNode even = head.next; // 2nd node is even 
        ListNode evenhead = even ; // maintain the even head for joining with odd 
        while(even != null && even.next != null){
            // moving the odd as odd is present on alternate places 
            odd.next = odd.next.next; // changing the pointers to point to node after 1 node which is odd
            odd = odd.next; 
            even.next = even.next.next;
            even = even.next;
        }
        // after odd and even is separated here we join even with oddd 
        odd.next = evenhead ;
        return head ; 
    }
}