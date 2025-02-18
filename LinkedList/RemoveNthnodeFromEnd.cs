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

// time complexity =O(n) space = O(1)
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // if only one node is present 
        if (head.next == null)
            return null;

        // move the fast pointer to n+1 times from start
        ListNode slow = head , fast =head ;
        for (int i =0; i<n ;i++){
            fast = fast.next;
        }

        // if the fast points to null after travelling n+1 time than the nth node from the last is head 
        if (fast== null)
            return head.next;

        // move the sow and fast together
        while(fast.next != null){
            slow  = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;
        return head ;

    }
}