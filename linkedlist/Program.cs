/*
    Lecture 6: DoublyLinkedList
*/

using System; 

namespace LinkedList {
    public class DoublyNode<T> {
        public T data {get; set;}
        public DoublyNode<T> prev {get; set;}
        public DoublyNode<T> next {get; set;}
    }
    public class DoublyLinkedList<T> {
        DoublyNode<T> head; 
        DoublyNode<T> tail; 
        int size; 

        public DoublyLinkedList() {
            head = null;
            tail = null; 
            size = 0; 
        }
        internal void Insert (T data) {
            DoublyNode<T> node = new DoublyNode<T>();
            node.data = data;

            if (size == 0) {
                node.prev = null; 
                node.next = null; 
                head = node;
                tail = node;
            } else {
                node.prev = tail;
                node.next = null; 
                tail.next = node;
                tail = node;
            }
            size++; 
        }
        internal void Traverse() {
            DoublyNode<T> node = new DoublyNode<T>();
            node = head; 
            for (int i = 0; i < size; ++i) {
                Console.Write($"{node.data} "); 
                node = node.next;
            }
        }
        internal void ReverseTraverse() {
            DoublyNode<T> node = new DoublyNode<T>();
            node = tail; 
            for (int i = 0; i < size; ++i) {
                Console.Write($"{node.data} "); 
                node = node.prev;
            }
        }
        internal bool Search(T data) {
            DoublyNode<T> node = new DoublyNode<T>();
            node = head; 
            for (int i = 0; i < size; ++i) {
                if (EQ(node.data, data)) return true;  
                node = node.next;
            }
            return false; 
        }
        
        internal static bool EQ (T x, T y) {
            if (typeof(T) == typeof(System.Int32)) return (Convert.ToInt32(x) == Convert.ToInt32(y)); 
            if (typeof(T) == typeof(System.Double)) return(Convert.ToDouble(x) == Convert.ToDouble(y)); 
            if (typeof(T) == typeof(System.String)) return(Convert.ToString(x) == Convert.ToString(y)); 
            if (typeof(T) == typeof(System.Char)) return(Convert.ToChar(x) == Convert.ToChar(y)); 
            return false; 
        } 
    }
    public class Test {
        static void Main(string[] args) {
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            dll.Insert(123); 
            dll.Insert(9); 
            dll.Insert(32); 
            dll.Insert(32); 
            dll.Insert(32); 

            dll.Traverse();
            Console.WriteLine();
            dll.ReverseTraverse(); 
            Console.WriteLine();

            Console.WriteLine(dll.Search(93)); 
            Console.WriteLine(dll.Search(9)); 

            DoublyLinkedList<string> dll2 = new DoublyLinkedList<string>();
            dll2.Insert("echo"); 
            dll2.Insert("sys"); 
            dll2.Insert("blb"); 
            dll2.Insert("ok"); 
            dll2.Insert("ali"); 

            dll2.Traverse();
            Console.WriteLine();
            dll2.ReverseTraverse(); 
            Console.WriteLine();

            Console.WriteLine(dll2.Search("ali")); 
            Console.WriteLine(dll2.Search("dsa")); 
        }
    }
}