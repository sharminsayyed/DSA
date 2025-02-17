/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
// time complexity =O(n) space =O(1)
public class Solution {
    public bool HasCycle(ListNode head) {
        if (head == null)
            return false;
        ListNode fast =head , slow =head;
        while (fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next; 
            // at any point if the fast pointer meets with the slow pointer means there is a cycle in the ll
            if(fast == slow){
                return true;
            }
        }
        return false;
    }
}