using System;

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
    }
}