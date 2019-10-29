using System;

namespace Merge_k_Sorted_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode[] lists = new ListNode[3];

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(5);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            ListNode l3 = new ListNode(2);
            l3.next = new ListNode(6);

            lists[0] = l1;
            lists[1] = l2;
            lists[2] = l3;

            var l = MergeKLists(lists);

            while (l != null)
            {
                Console.WriteLine(l.val);
                l = l.next;
            }

            Console.ReadKey();
        }

        public static ListNode Init(int[] nums)
        {
            ListNode ans = new ListNode(0);
            ListNode next = ans;

            for (int i = 0; i < nums.Length; i++)
            {
                next = new ListNode(nums[i]);
                next = next.next;
            }
            return ans.next;
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            ListNode ans = new ListNode(0);
            ListNode next = ans;

            bool loop = true;

            while (loop)
            {
                int index = 0;
                ListNode min = lists[0];

                for (int i = 1; i < lists.Length; i++)
                {
                    if (min == null)
                    {
                        min = lists[i];
                        index = i;
                    }
                    else
                    {
                        if (lists[i] == null || lists[i].val > min.val)
                        {
                            continue;
                        }
                        else
                        {
                            min = lists[i];
                            index = i;
                        }
                    }
                }

                if (min == null)
                {
                    break;
                }

                next.next = new ListNode(min.val);
                next = next.next;

                lists[index] = min.next;
            }

            return ans.next;
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
