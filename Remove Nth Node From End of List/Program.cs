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
            //TODO Remove_Nth_Node_From_End_of_List
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
            {
                return null;
            }

            if (head.next == null && n == 0)
            {
                return null;
            }

            ListNode list = null;

            var count = 0;

            list = new ListNode(head.val);

            while (head.next != null)
            {

                if (count == n)
                {

                }

                count++;
            }

            return list;
        }

        public ListNode GenerateListNode(ListNode head, int next)
        {
            head.next = new ListNode(next);

            return head;
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
