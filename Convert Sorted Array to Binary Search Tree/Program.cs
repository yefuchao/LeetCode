using System;

namespace Convert_Sorted_Array_to_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { -10, -3, 0, 1, 9 };


            SortedArrayToBST(nums);

            Console.ReadKey();
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {

            if (nums.Length == 0)
            {
                return null;
            }

            return BuildTree(nums, 0, nums.Length-1);

        }

        public static TreeNode BuildTree(int[] nums, int start, int end)
        {
            int mid = (end + start) / 2;
            TreeNode tree = new TreeNode(nums[mid]);
            if (start <= mid - 1)
            {
                tree.left = BuildTree(nums, start, mid - 1);
            }
            if (mid + 1 <= end)
            {
                tree.right = BuildTree(nums, mid + 1, end);
            }
            return tree;
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


