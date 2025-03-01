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
 // time complexity = O(2n) space = O(1)
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null) return null;
        int len =1 ;
        ListNode tail = head ;
        while(tail.next != null){
            len ++; //calculate the length of LL
            tail = tail.next; // find the last node of LL from there only we have to rotate 
        }
        if(k %len == 0) return head ; // means it will come back to the same head if rotated (if k is divisible by length)
        k = k%len; // update k if not divisible 
        tail.next = head ; 
        ListNode newlastnode  = findnode(head ,len-k); // find the element which will be lastnode after rotation of k times
        head = newlastnode.next;
        newlastnode.next =null;

        return head ;
    }

    private ListNode findnode(ListNode temp ,int k){
        int cnt =1;
        while(temp != null){
            if (cnt == k) return temp;
            cnt++;
            temp=temp.next;
        }
        return temp;
    }
}