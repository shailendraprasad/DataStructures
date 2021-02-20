using System;

namespace Trees
{
    class TreeDriver
    {
        static readonly int COUNT = 10;

        static void Main(string[] args)
        {
            Tree tr = new Tree();
            tr.insert(25);
            tr.insert(35);
            tr.insert(19);
            tr.insert(10);
            tr.insert(11);

            tr.lookup(10);
            tr.lookup(99);
            tr.BreadhFirstSearch();
            print2D(tr.root);
        }

        // Function to print binary tree in 2D  
        // It does reverse inorder traversal  
        static void print2DUtil(Node root, int space)
        {
            // Base case  
            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.item + "\n");

            // Process left child  
            print2DUtil(root.left, space);
        }

        // Wrapper over print2DUtil()  
        static void print2D(Node root)
        {
            // Pass initial space count as 0  
            print2DUtil(root, 0);
        }
    }
}
