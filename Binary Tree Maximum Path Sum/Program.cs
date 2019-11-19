using System;

namespace Binary_Tree_Maximum_Path_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode root = new TreeNode(-10);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(-7);

            Console.WriteLine(MaxPathSum(root));

            Console.ReadKey();
        }

        static int val = 0;

        public static int MaxPathSum(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            val = root.val;

            GetMax(root);
            return val;
        }

        public static int GetMax(TreeNode root)
        {
            int left = 0;
            int right = 0;
            if (root.left != null)
            {
                left = Math.Max(root.left.val, GetMax(root.left));
            }

            if (root.right != null)
            {
                right = Math.Max(root.right.val, GetMax(root.right));
            }

            int max = root.val;

            val = Math.Max(val, Math.Max(Math.Max(Math.Max(max, max + left), max + right), max + left + right));

            return Math.Max(Math.Max(Math.Max(max, max + left), max + right), max + left + right);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
}
