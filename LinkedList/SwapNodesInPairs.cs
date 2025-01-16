/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *    public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

 // in place reversal pattern 
 //timecomplexity = O(n) space =O(1)
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        // creating a dummy node so we can use it as prevnode 
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        // used of loop condition and joining the pairs of node together 
        ListNode prev =dummy ;

        // if the linked list ie even then there are aalways two pairs to swap 
        // if odd then the last node will not be swap 
        // this loop checks whether the next part of the node is null or not 
        while(prev.next!= null && prev.next.next != null){
            // assigning the first and second node to be swapped 
            ListNode first = prev.next;
            ListNode second = first.next;

            //swapping the nodes 
            first.next = second.next;
            second.next = first;
            prev.next =second;

            // moving the prevnode 
            prev =first;

        }
        return dummy.next;
    }
}