using System;
using System.Collections;
using System.Collections.Generic;

namespace Trees
{
    public class Tree
    {
        public Node root;

        public int? lookup(int number)
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                bool found = true;
                Node temp = root;
                while (found)
                {
                    if (number > temp.item)
                    {
                        temp = temp.right;
                    }
                    else
                    {
                        temp = temp.left;
                    }
                    if (temp.item == null)
                    {
                        Console.WriteLine($"The number {number} is not found");
                        return null;
                    }
                    if (temp.item == number)
                    {
                        Console.WriteLine($"The number {number} is found");
                        return temp.item;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Inserting the value in the tree
        /// Loop with the while until the value is inserted
        /// Using the BST
        /// </summary>
        /// <param name="number"></param>
        public void insert(int number) {
            bool toInsert = true;
            
            if(root == null){
                root = new Node();
                root.item = number;
                root.right = new Node();
                root.left = new Node();
     
            }
            else {
                Node Temp = root;
                while (toInsert){
                    
                    if(number > Temp.item){
                        Temp = Temp.right;
                    }
                    else {
                        Temp = Temp.left;
                    }
                    if(Temp.item == null){
                        Temp.item = number;
                        Temp.right = new Node();
                        Temp.left = new Node();
                        toInsert = false;
                    }
                }
            }
        } 

        /// <summary>
        /// Acheived through using queue
        /// Visit nodes from left to right and add them in queue
        /// </summary>
        public void BreadhFirstSearch()
        {
            List<int> final = new List<int>();
            Node currentNode = this.root;
            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(currentNode);

            while(queue.Count > 0)
            {
                var nodeTemp = queue.Dequeue();
                if (nodeTemp != null && nodeTemp.item != null)
                {
                    final.Add(nodeTemp.item.Value);
                    queue.Enqueue(nodeTemp.left);
                    queue.Enqueue(nodeTemp.right);
                }
            }

            final.ForEach(x => Console.WriteLine(x));
        }
    }
}