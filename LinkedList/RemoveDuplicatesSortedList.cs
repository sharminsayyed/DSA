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
 // time complexity = O(n) space = O(1)
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        ListNode prev =head ,temp = prev.next; // prev and temp for comparing and travesing the LL
        while(temp != null){
            if(prev.val == temp.val){
                temp =temp.next ; // simply move forward if the value is similar
            }
            else{
                prev.next = temp ; // change the links
                prev = temp; // move prev
                temp = temp.next ;// move temp
            }
        }
        prev.next = null; // make the end of LL be null
        return head ;
    }
}