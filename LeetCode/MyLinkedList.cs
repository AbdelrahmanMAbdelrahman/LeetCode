using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MyLinkedList
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = l1;
            while (l1 != null&&l2!=null) {
                l1.val += l2.val;
                l1=l1.next;
                l2=l2.next;
            }
            return l1;
        }
    }
    public class ListNode
    {
     public int val;
     public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
                 }
  }
}
