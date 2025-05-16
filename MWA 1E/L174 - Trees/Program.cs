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

        static void InOrderTraverse(TreeNode[] tree, int n)
        {
            if (n != 0)
            {
                InOrderTraverse(tree, tree[n].Left);
                Console.WriteLine(tree[n].Data);
                InOrderTraverse(tree, tree[n].Right);
            }
        }

        static void Main(string[] args)
        {
            TreeNode[] tree = new TreeNode[10];

            tree[1] = new TreeNode(2, 5, "Humboldt");
            tree[2] = new TreeNode(0, 3, "ADELIE");
            tree[3] = new TreeNode(4, 7, "Emperor");
            tree[4] = new TreeNode(0, 0, "African");
            tree[5] = new TreeNode(8, 6, "Macaroni");
            tree[6] = new TreeNode(0, 0, "Snares");
            tree[7] = new TreeNode(0, 0, "Fairu");
            tree[8] = new TreeNode(0, 0, "King");

            InOrderTraverse(tree, 1);

            Console.ReadKey();
        }
    }
}
