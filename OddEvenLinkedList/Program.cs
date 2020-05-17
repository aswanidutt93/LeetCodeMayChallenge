using System;

namespace OddEvenLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            OddEvenList(list);
        }

        public static ListNode OddEvenList(ListNode head)
        {
            ListNode odd = head;
            ListNode even = new ListNode(head.next.val,null);
            int oddcount = 1;
            while (odd.next != null)
            {
                if (oddcount % 2 == 0)
                {
                    even.next = odd.next.next;
                   // odd.next = odd.next.next;
                }
                else
                {
                    odd.next = odd.next.next;
                }
                oddcount++;
            }


            return odd;

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