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

// time complexity = O(n/2+n/2+n/2+n/2) = O(2n) space =O(1)
public class Solution {
    public bool IsPalindrome(ListNode head) {
        // if only one element and no element 
        if (head  == null || head.next == null)
            return true;
        
        // find the middle  of linkded list 
        ListNode middle =  findmiddle(head); // first half end 
        ListNode newhead =reverseLL(middle.next) ;// it will give us the head of the reversed 2nd half 

        // compare the fist half and second half 
        ListNode first =head , second = newhead ;
        while(second != null){ // tc = O(n/2) 
            if(first.val != second.val){
                //is not palindrome so again reverse the second half and bring to it original place 
                reverseLL(newhead);  // tc= O(n/2)
                return false;
            }
            // move first and second half to check all values 
            first = first.next;
            second  =second.next ;
        }
        
        // is palindrome so again reverse the second half and bring to it original place 
        reverseLL(newhead);
        return true;
    }
    
// time complexity here  = O(n/2) beacause we reverese half node
    public ListNode reverseLL(ListNode head){
        ListNode prev =null ,curr =head ,next =null;
        while(curr != null){
            next = curr.next;
            curr.next = prev;
            prev =curr;
            curr =next;
        }
        return prev;
    }

// time complexity here  = O(n/2) beacause we traverse till middle only 
    public ListNode findmiddle(ListNode head){
        ListNode slow =head ,fast =head;
        while(fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow ;

    }
}