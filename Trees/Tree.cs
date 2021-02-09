namespace Trees
{
    public class Tree
    {
        public Node root;

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