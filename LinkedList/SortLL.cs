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
 // time complexity = O(logn (n+ n/2)) Ologn = mergesort depth , n= merge 2 LL , n/2 = middleofLL
 // space =O(1)
public class Solution {
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) return head ; // base case for recursion

        ListNode mid = findmiddle(head); // find the middle of the LinedList 
        ListNode lefthead = head , righthead = mid.next ; // assign the left side and right side for sorting as we merge sort 
        mid.next = null ; // disconnect the LL 
        // sort the Leftside and right side of LL using merge sort (recursive)
        lefthead = SortList(lefthead); // reintialize the head which will be sorted
        righthead = SortList(righthead);
        // merge the 2 sorted list 
        return merge2(lefthead ,righthead);
        
    }

    public ListNode findmiddle( ListNode head){
        if(head == null || head.next == null) return head;
        ListNode slow = head , fast = head;
        while(fast.next != null && fast.next.next != null ){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;    
    }

    public ListNode merge2( ListNode list1 , ListNode list2){
        ListNode dummy = new ListNode(0);
        ListNode t1 = list1 , t2 =list2, temp = dummy;
        while(t1 != null && t2 != null){
            if (t1.val < t2.val){
                temp.next =t1;
                temp=t1;
                t1 = t1.next;
            }
            else{
                temp.next =t2;
                temp=t2;
                t2 = t2.next;
            }
        }
        if (t1 != null)
            temp.next =t1;
        else
            temp.next =t2;

        return dummy.next;
    }
}