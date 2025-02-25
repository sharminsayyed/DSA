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

 // time complexity = O(n1+n2) space =O(1)
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        ListNode dummy = new ListNode(0);
        ListNode t1 =list1 , t2 = list2 ,temp = dummy; // temp is used for traversal

        while(t1 != null && t2 != null){
            if(t1.val < t2.val){ // compare the val from both the list
                temp.next = t1;
                temp =t1;
                t1 = t1.next; // move the t1 in the specified list
            }
            else{
                temp.next = t2;
                temp=t2;
                t2 = t2.next; // move t2 in specified list 
            }
        }
        if( t1 != null)
            temp.next = t1;
        else
            temp.next = t2;

        return dummy.next;


        
    }
}