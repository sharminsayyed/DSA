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
 // very hard 
 // 25 
 // in place reversal pattern 
 // time complexity = O(2n) sapce =O(1)
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if(head == null || k<= 0) return head ;
        // in this we break the intial linked this in k groups and then join them together 
        ListNode temp =head ;
        ListNode kthnode ,nextnode,prevnode;
        kthnode = nextnode =prevnode =null;
        while (temp != null){
            kthnode = findkthnode (temp ,k); // find the k group of ll
            if(kthnode == null){
                // there is no k group elements like if k= 3 but there are only 2 or 1 element left 
                // then check if prevnode is there and connect it with the remaining LL
                if(prevnode != null) prevnode.next = temp;
                break;
            }
            nextnode =kthnode.next ;// saving the link to move the temp 
            kthnode.next = null; // creating the separate linked list 
            reverseLL(temp) ; // reverse the separated  LL
            if (temp == head ){
                // for first k group assingning the head 
                head =kthnode ;
            }
            else{
                // for other k groups link the previous node of the previous k group 
                prevnode.next = kthnode ;
            }
            prevnode = temp ; // remember the previous node beacuse we have to link to the next separate LL
            temp = nextnode ;

        } 
        return head ;
    }
    public ListNode findkthnode(ListNode temp ,int k){
        k = k-1;
        // why it will start from the  0 indexing if  k=3 then it will be 0 1 2=kthnode 
        while (temp != null && k>0){
            k--; 
            temp = temp.next; //ktnode increments here 
        }
        return temp ;
    }

    // reverse a linked list
    public ListNode reverseLL(ListNode head){
        ListNode current = head , prev,next;
        prev=next =null;
        while(current != null){
            next = current.next;
            current.next = prev;
            prev = current ;
            current =next;
        }
        return prev ;
    }
}