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
 // time complexity = O(n) and space = O(1)
public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        // iterative 
        // assign the current node to head , and let the previous node and next node be null
        ListNode current  = head ;
        ListNode prev=null ,next=null;
        // check until to find the last node where current.next= 0
        while(current != null){
            next = current.next; // save the next node 
            current.next =prev; // connect to the previous node 
            prev = current; // move the previous node and current node 
            current =next;
        } 
        //when all the node as reversed current =next =0 and prev will point to the last node 
        return prev ; // return the previous node as it is the head now 
        


        /*
        // recursive 

        if (head == null || head.next == null) // base case - for 1 or 0 node 
            return head ;
        
        ListNode newhead = ReverseList(head.next);  // returns the newhead from where we have the reverse 
        ListNode current  = head.next;
        current.next = head;
        head.next = null;
        return newhead;

        */


    }
}