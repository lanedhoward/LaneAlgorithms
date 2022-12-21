using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public class Trees
    {
        public static void Demo()
        {
            string shortpath = "../../../Data/shortscores.txt";
            string longpath = "../../../Data/scores.txt";
            int[] array;

            array = Sorting.LoadInts(longpath);
            Sorting.BubbleSort(array);

            BinaryTree tree = new BinaryTree(array);
            TreeNode.PostOrderTraversal(tree.root);
        }
    }

    public class TreeNode
    {
        public int value;
        public TreeNode? leftNode;
        public TreeNode? rightNode;

        public TreeNode(int _value)
        {
            this.value = _value;
            leftNode = null;
            rightNode = null;
        }

        public static void PreOrderTraversal(TreeNode? current)
        {
            if (current == null) return;

            Console.WriteLine(current.value);

            PreOrderTraversal(current.leftNode);
            PreOrderTraversal(current.rightNode);
        }
        public static void InOrderTraversal(TreeNode? current)
        {
            if (current == null) return;

            InOrderTraversal(current.leftNode);
            
            Console.WriteLine(current.value);

            InOrderTraversal(current.rightNode);
        }
        public static void PostOrderTraversal(TreeNode? current)
        {
            if (current == null) return;

            PostOrderTraversal(current.leftNode);
            PostOrderTraversal(current.rightNode);

            Console.WriteLine(current.value);
        }
    }

    public class BinaryTree
    {
        public TreeNode? root;

        public BinaryTree(int[] array)
        {
            root = Insert(array, 0);
        }

        public TreeNode? Insert(int[] array, int index)
        {
            TreeNode? result = null;

            if (index < array.Length)
            {
                result = new TreeNode(array[index]);

                result.leftNode = Insert(array, (2 * index) + 1);
                result.rightNode = Insert(array, (2 * index) + 2);
            }

            return result;
        }
    }
}
