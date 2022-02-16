using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Nodes_in_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode head = new ListNode(1)
            {
                next = new ListNode(2),
                val = 1
            };

            var t = SwapPairs(head);
            Console.ReadLine();
        }

        public static ListNode SwapPairsRecursion(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            var firstNode = head;
            var secondNode = head.next;

            firstNode.next = SwapPairsRecursion(secondNode.next);
            secondNode = firstNode;

            return secondNode;
        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode node = new ListNode(0);

            Queue<int> one = new Queue<int>();
            Queue<int> two = new Queue<int>();

            var count = 0;

            while (head != null)
            {
                if (count % 2 == 0)
                {
                    one.Enqueue(head.val);

                }
                else
                {
                    two.Enqueue(head.val);
                }

                head = head.next;
                count++;
            }

            Queue<int> all = new Queue<int>();

            while (two.Count > 0 || one.Count > 0)
            {
                if (two.Count > 0)
                {
                    all.Enqueue(two.Dequeue());
                }

                if (one.Count > 0)
                {
                    all.Enqueue(one.Dequeue());
                }
            }

            node = GenerateListNode(node.next, all);

            return node;

        }

        public static ListNode GenerateListNode(ListNode node, Queue<int> queue)
        {
            if (queue.Count > 0)
            {
                node = new ListNode(queue.Dequeue());
                node.next = GenerateListNode(node.next, queue);
                return node;
            }

            return null;

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
