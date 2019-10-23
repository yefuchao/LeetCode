using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Nth_Node_From_End_of_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);

            var t = RemoveNthFromEnd(list, 2);

            while (t != null)
            {
                Console.WriteLine(t.val);
                t = t.next;
            }

            Console.ReadKey();
        }

        public static ListNode RemoveNthFromEndII(ListNode head, int n)
        {
            //计算链表的长度

            ListNode temp = head;

            int length = 0;
            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            temp = head;

            if (length == n)
            {
                return head.next;
            }

            //去掉的前一个
            ListNode pre = head;

            for (int i = 0; i < length - n - 1; i++)
            {
                pre = pre.next;
            }

            //ListNode next = head;

            //for (int i = 0; i < length - n; i++)
            //{
            //    next = next.next;
            //}

            pre.next = pre.next.next;

            return pre;
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            ListNode dummy = new ListNode(0);
            dummy.next = head;

            int length = 0;

            ListNode first = head;

            while (first != null)
            {
                length++;
                first = first.next;
            }

            length -= n;

            first = dummy;

            while (length > 0)
            {
                length--;
                first = first.next;
            }

            first.next = first.next.next;

            //TODO think why

            return dummy.next;
        }


        public class ListNode
        {
            public int val { get; set; }

            public ListNode next { get; set; }

            public ListNode(int x)
            {
                val = x;
            }
        }
    }
}
