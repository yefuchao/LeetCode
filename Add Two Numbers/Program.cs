using System;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListNode l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            ListNode l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };

            var r = AddTwoNumbers(l1, l2);



            Console.ReadKey();

        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);

            ListNode p = l1, q = l2, curr = dummyHead;

            var a = l1?.val ?? 0;



            int carry = 0;

            while (p != null || q != null)
            {



                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                var sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }
    }
}
