using System; 

namespace BinaryTreeImplementaion {
    class TreeNode<T> {
        public T entry {get; set;}
        public TreeNode<T> left {get; set;}
        public TreeNode<T> right {get; set;}
    }
    class BinaryTree<T> {
        TreeNode<T> root = new TreeNode<T>();
        int siz; 

        public BinaryTree() {
            root = null; 
            siz = 0; 
        }
        internal void InorderTraverseRec(TreeNode<T> node) {
            if (node != null) {
                InorderTraverseRec(node.left); 
                Console.Write($"{node.entry} "); 
                InorderTraverseRec(node.right);
            }
        }
        internal void InorderTraverse() {
            InorderTraverseRec(root); 
        }
        internal bool Empty() {
            return root == null; 
        }
        internal bool Full() {
            return false; 
        }
        internal void ClearTreeRec(TreeNode<T> node) {
            if (node != null) {
                ClearTreeRec(node.left); 
                ClearTreeRec(node.right); 
                
                node.left = null; 
                node.right = null; 
            } 
        }
        internal void Clear() {
            ClearTreeRec(root); 
            root = null; 
            siz = 0; 
        }
        internal void InsertTreeRec(TreeNode<T> node, T entry) {
            if (node != null) {
                node.entry = entry; 
                node.left = null; 
                node.right = null; 
            } else if (Convert.ToInt32(entry) < Convert.ToInt32(node.entry)) {
                InsertTreeRec(node.left, entry); 
            } else {
                InsertTreeRec(node.right, entry); 
            }
        }
        internal void InsertIter(T entry) {
            TreeNode<T> node = new TreeNode<T>();
            TreeNode<T> prev = new TreeNode<T>();
            TreeNode<T> curr = new TreeNode<T>();

            node.entry = entry; 
            node.right = null; 
            node.left = null;

            if (root == null) {
                root = node;
            } else {
                curr = root; 
                while(curr != null) {
                    prev = curr; 
                    if (Convert.ToInt32(entry) < Convert.ToInt32(curr.entry)) curr = curr.left; 
                    else curr = curr.right; 
                }
                if (Convert.ToInt32(entry) < Convert.ToInt32(prev.entry)) prev.left = node; 
                else prev.right = node; 
            }
            siz++;  
        }
        internal void Insert(T entry) {
            InsertIter(entry); 

            // TreeNode<T> node = new TreeNode<T>();
            // node.entry = entry; 
            // node.right = null; node.left = null;
            // InsertTreeRec(node, entry); 
        }
        internal bool Find(T entry) {
            bool found = false; 
            TreeNode<T> node = new TreeNode<T>();

            while (node != null && !(found = (Convert.ToInt32(node.entry) == Convert.ToInt32(entry)))) {
                if (Convert.ToInt32(entry) < Convert.ToInt32(node.entry)) node = node.left; 
                else node = node.right;
            }

            return found; 
        }
        internal void DeleteNode(TreeNode<T> node) {
            TreeNode<T> del_node = new TreeNode<T>();
            del_node = node;


            if (node.left == null) node = node.left;
            else if (node.right == null) node = node.right; 
            else {
                if (node.left.right == null) {
                    TreeNode<T> holdNode = new TreeNode<T>();
                    holdNode = node.left;
                    node.entry = holdNode.entry;
                    node.left = holdNode.left;
                } 
                else {
                    TreeNode<T> r = new TreeNode<T>();
                    while(del_node.right != null) {
                        r = del_node; 
                        del_node = del_node.right; 
                    }
                    node.entry = del_node.entry; 
                    r.right = del_node.left;
                }
            }

            del_node = null; 
        }
        internal bool Delete(T entry) {
            bool found = false; 
            TreeNode<T> node = new TreeNode<T>();
            TreeNode<T> par = new TreeNode<T>();
            node = root; 
            par = null; 

            while (node != null && !(found = (Convert.ToInt32(node.entry) == Convert.ToInt32(entry)))) {
                par = node; 
                if (Convert.ToInt32(entry) < Convert.ToInt32(node.entry)) node = node.left; 
                else node = node.right; 
            }
            if (found) {
                if (par == null) DeleteNode(node); 
                else if (Convert.ToInt32(entry) < Convert.ToInt32(node.entry)) DeleteNode(node.left);
                else DeleteNode(node.right); 
            }
          
            return found; 
        }
        internal int Size() { 
            return siz; 
        }
    }
    class Program {
        static void Main(string[] args) {
            BinaryTree<int> t1 = new BinaryTree<int>();

            t1.Insert(3);
            t1.Insert(10);
            t1.Insert(2);
            t1.Insert(2);
            t1.Insert(32);
            t1.Insert(392);
            t1.Insert(2);

            t1.InorderTraverse();
            Console.WriteLine();

            t1.Delete(3);
            t1.InorderTraverse();
            Console.WriteLine();
            
            t1.Clear();
            t1.InorderTraverse();
            Console.WriteLine();
        }
    }
} 
