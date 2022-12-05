using System;

namespace StackImplementation {
    class StackNode<T> {
        internal T data {get; set;}
        internal StackNode<T> next {get; set;}
    }
    class Stack<T> {
        StackNode<T> node;
        int siz = 0; 
        public Stack() {
            node = null; 
        }
        internal void Push(T data) {
            StackNode<T> new_node = new StackNode<T>();
            new_node.data = data; 
            new_node.next = node; 
            node = new_node; 
            siz++;
        }
        internal bool Full() {
            return false; 
        }
        internal T Pop() {
            T deleted_node = node.data; 
            if (deleted_node != null) {
                siz--;
            }
            node = node.next;
            return deleted_node;
        }
        internal bool Empty() {
            return node == null; 
        }
        internal T Top() {
            return node.data;
        }
        internal int Size() {
            return siz; 
        }
        internal void Clear() {
            StackNode<T> top = new StackNode<T>();
            while (node != null) {
                top = node;
                top = null;
                node = node.next;
            }
            siz = 0; 
        }
        internal void Print() {
            StackNode<T> top = new StackNode<T>();
            top = node;
            while (node != null) {
                Console.Write($"{node.data} ");
                node = node.next;
            }
            node = top;
        }
    }
    class Program {
        static void Main(string[] args) {
            // test int stack
            Stack<int> sk = new Stack<int>();

            sk.Push(2); 
            sk.Push(4); 
            sk.Push(1); 
            sk.Push(39); 
            sk.Print();
            Console.WriteLine();
            Console.WriteLine(sk.Top());
            Console.WriteLine(sk.Size());

            sk.Pop();
            sk.Print();
            Console.WriteLine();
            Console.WriteLine(sk.Size());


            sk.Clear();
            sk.Print();
            Console.WriteLine();
            Console.WriteLine(sk.Size());
            Console.WriteLine(sk.Empty());

            sk.Push(2); 
            sk.Push(4); 
            sk.Push(1);
            sk.Print();
            Console.WriteLine();
            Console.WriteLine(sk.Size());

            // test string stack
            Stack<string> str_sk = new Stack<string>();
            str_sk.Push("ahi");  
            str_sk.Push("echo"); 
            str_sk.Push("sys"); 
            str_sk.Print(); 

            if (!str_sk.Empty()) str_sk.Pop(); 
            str_sk.Print(); 

            if (!str_sk.Empty()) Console.WriteLine(str_sk.Top());

            if (!str_sk.Full()){
                str_sk.Push("cd .."); 
                str_sk.Push("cd ecpc/acpc/icpc/winner ");
            }
            str_sk.Print();
        }
    }
}
