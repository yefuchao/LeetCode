﻿using System;
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
            //TODO Swap_Nodes_in_Pairs

            ListNode head = new ListNode(1)
            {
                next = new ListNode(2),
                val = 1
            };

            var t = SwapPairs(head);
            Console.ReadLine();
        }

        public static ListNode SwapPairs(ListNode head)
        {
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

            node = GenerateListNode(node, all);

            return node.next;

        }

        public static ListNode GenerateListNode(ListNode node, Queue<int> queue)
        {
            if (queue.Count > 0)
            {
                node.next = new ListNode(queue.Dequeue());
                return GenerateListNode(node.next, queue);
            }

            return node.next;

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
