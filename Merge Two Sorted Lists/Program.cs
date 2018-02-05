using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l2 == null)
            {
                return l1;
            }

            if (l1 == null)
            {
                return l2;
            }

            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l2.next, l1);
                return l2;
            }
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
