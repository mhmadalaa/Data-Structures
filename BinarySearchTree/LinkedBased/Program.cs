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
        int depth; 

        public BinaryTree() {
            root = null; 
            siz = 0; 
            depth = 0; 
        }
        internal void InorderTraverseRec(TreeNode<T> node) {
            if (node != null) {
                InorderTraverseRec(node.left); 
                Console.Write($"{node.entry}"); 
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
                node = null; 
            }
        }
        internal void Clear() {
            ClearTreeRec(root); 
            siz = 0; 
            depth = 0;
        }
        internal int Size() {

        }
        internal int Depth() {

        }
        internal void Preoder() {

        }
        internal void Inorder() {

        }
        internal void Postorder() {

        }
    }
    class Program {
        static void Main(string[] args) {
            
        }
    }
}