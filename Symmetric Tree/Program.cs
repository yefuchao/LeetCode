using System;
using System.Collections.Generic;
using System.Linq;

namespace Symmetric_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            Console.WriteLine(IsSymmetric(root));
            Console.ReadLine();
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null && root.right == null)
            {
                return false;
            }

            if (root.right != null && root.left == null)
            {
                return false;
            }

            List<TreeNode> cur = new List<TreeNode>();

            cur.Add(root);

            while (cur.Count > 0)
            {
                List<TreeNode> next = new List<TreeNode>();

                foreach (var item in cur)
                {
                    next.Add(item.left);

                    next.Add(item.right);
                }

                var nextLen = next.Count;

                var begin = 0;
                var end = nextLen - 1;

                while (begin <= end)
                {
                    if (next[begin] != null && next[end] != null)
                    {
                        if (next[begin].val != next[end].val)
                        {
                            return false;
                        }

                        begin++;
                        end--;
                        
                    }
                    else if( next[begin] == null && next[end] == null)
                    {
                        begin++;
                        end--;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                cur = new List<TreeNode>();
                foreach (var item in next)
                {
                    if(item != null)
                    {
                        cur.Add(item);
                    }
                }

            }

            return true;
        }



    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
