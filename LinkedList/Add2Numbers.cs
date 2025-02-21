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
// time complexity = O(max(l1,l2)) space = O(max(l1,l2))
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode t1 = l1 ,t2 =l2; // this is used to traverse 2 LL
        int carry =0; // to carry numbers from the sum
        ListNode dummy = new ListNode(0); // for the sum list 
        ListNode curr = dummy; // to traverse through the sum list 
        while(t1  != null || t2 != null || carry > 0 ){
            int sum =carry; // adding the t1+t2
            if(t1 != null)  sum += t1.val;
            if(t2 != null)  sum += t2.val;
           
            ListNode newnode = new ListNode(sum %10); // create a new node and put the added value here = 10%10= 0 , 9%10 = 9 
            carry = sum/10; // 12/10 = 2 , 10/10 = 1 , here 2 and 1 will be stored in carry 

            curr.next = newnode; // moving in the sumlist using curr 
            curr =newnode ;

            if(t1 != null) t1 = t1.next; // move the t1 (1st LL) and t2(2nd LL) pointers to next value to add them
            if(t2 != null) t2 =t2.next;

        }
        return dummy.next;
    }
}