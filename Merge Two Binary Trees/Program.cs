using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t2 == null)
            {
                return t1;
            }

            if (t1 == null)
            {
                return t2;
            }

            TreeNode tree = new TreeNode(t1.val + t2.val)
            {
                left = MergeTrees(t1.left, t2.left),
                right = MergeTrees(t1.right, t2.right)
            };

            return tree;
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
