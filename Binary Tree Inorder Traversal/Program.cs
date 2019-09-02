using System;
using System.Collections.Generic;

namespace Binary_Tree_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            //root.right = new TreeNode(2);
            root.left.right = new TreeNode(2);
            //root.left.right = new TreeNode(4);
            //root.right.left = new TreeNode(3);
            //root.right.right = new TreeNode(3);

            var r = InorderTraversal(root);

            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


        public static IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();

            var store = new Stack<TreeNode>();

            var temp = root;

            var isPop = false;

            while (temp != null)
            {
                if (temp.left != null && isPop == false)
                {
                    store.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    isPop = false;
                    result.Add(temp.val);


                    if (temp.right != null)
                    {
                        temp = temp.right;
                    }
                    else
                    {
                        if (store.Count > 0)
                        {
                            temp = store.Pop();
                            isPop = true;
                        }
                        else
                        {
                            temp = null;
                        }
                    }
                }

            }

            return result;
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
