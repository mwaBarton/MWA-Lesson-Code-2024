using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L174___Binary_Trees
{

    internal class Program
    {
        struct TreeNode
        {
            public int Left, Right;
            public string Data;

            public TreeNode(int left, int right, string data)
            {
                Left = left;
                Right = right;
                Data = data;
            }
        }

        static void InOrderTraverse(TreeNode[] tree, int currentNode)
        {
            if (currentNode != 0)
            {
                // Left
                InOrderTraverse(tree, tree[currentNode].Left);

                // Print
                Console.WriteLine(tree[currentNode].Data);

                // Right
                InOrderTraverse(tree, tree[currentNode].Right);
            }
        }

        static void PreOrderTraverse(TreeNode[] tree, int currentNode)
        {
            if (currentNode != 0)
            {
                // Print
                Console.WriteLine(tree[currentNode].Data);
                // Left
                PreOrderTraverse(tree, tree[currentNode].Left);

                

                // Right
                PreOrderTraverse(tree, tree[currentNode].Right);
            }
        }

        static void Main(string[] args)
        {
            TreeNode[] tree = new TreeNode[10];

            tree[1] = new TreeNode(2, 5, "Humboldt");
            tree[2] = new TreeNode(0, 3, "Adelie");
            tree[3] = new TreeNode(4, 7, "Emperor");
            tree[4] = new TreeNode(0, 0, "African");
            tree[5] = new TreeNode(8, 6, "Macaroni");
            tree[6] = new TreeNode(0, 0, "Snares");
            tree[7] = new TreeNode(0, 0, "Fairy");
            tree[8] = new TreeNode(0, 0, "King");

            PreOrderTraverse(tree, 1);


            string[] data = new string[10];
            int[] leftPointers = new int[10];
            int[] rightPointers = new int[10];


            Console.ReadKey();
        }
    }

    public class Node
    {
        public string data;
        public Node leftChild;
        public Node rightChild;
    }

}
