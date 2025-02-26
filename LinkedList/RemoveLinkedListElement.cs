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
 // time complexity =O(n) space= O(1)
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null) return head;
        ListNode dummy = new ListNode(0); // create a dummy node to check if the head.val == val
        dummy.next=head;
        ListNode curr = dummy; // used to check the values in LL
        while(curr.next != null){
            if (curr.next.val == val) 
                curr.next = curr.next.next; // if the val is same change the pointers
            else
                curr = curr.next; // if not move in forward in the list 
        }
        return dummy.next;
    }
}