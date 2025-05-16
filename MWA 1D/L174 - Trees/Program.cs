using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L174___Trees
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

        static void InOrder(TreeNode[] tree, int n)
        {
            if (n != 0)
            {
                InOrder(tree, tree[n].Left);
                Console.WriteLine(tree[n].Data);
                InOrder(tree, tree[n].Right);
            }
        }

        static void Main(string[] args)
        {
            TreeNode[] tree = new TreeNode[10];

            tree[1] = new TreeNode(2, 5, "Humbolt");
            tree[2] = new TreeNode(0, 3, "Adelie");
            tree[3] = new TreeNode(4, 7, "Emperoro");
            tree[4] = new TreeNode(0, 0, "African");
            tree[5] = new TreeNode(8, 6, "Macaroni");
            tree[6] = new TreeNode(0, 0, "Snares");
            tree[7] = new TreeNode(0, 0, "Fairy");
            tree[8] = new TreeNode(0, 0, "King");

            InOrder(tree, 1);

            Console.ReadKey();

        }
    }
}
