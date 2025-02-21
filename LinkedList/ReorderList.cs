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
public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return ;

        ListNode middle = findMiddle(head);// find the middle of Linkedlist 
        ListNode newhead = reverseLL(middle.next); // reverse the second half 
        middle.next = null; // till middle we have the 1st half / after middle 2nd half which is reversed

        // reorder 1st = 1st half , 2nd = 2nd half , 3rd = 1st half ,4th = 2nd half ....
        ListNode first =head ,second =newhead;
        while(second != null){
           ListNode t1 = first.next ,t2 = second.next; // to store the next element in both LL
           // arrange 
           first.next = second ;
           second.next = t1 ;
           // move in the both LL 
           first =t1;
           second =t2;
        }
    }

    // reverse the half LL
    public ListNode reverseLL(ListNode head){
        ListNode prev =null ,next =null,curr =head;
        while (curr != null){
            next = curr.next;
            curr.next =prev;
            prev =curr;
            curr =next;
        }
        return prev;
    }
    // find mid point of LL
    public ListNode findMiddle(ListNode head){
        ListNode slow =head ,fast =head ;
        while(fast.next != null && fast.next.next != null){
            slow =slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}