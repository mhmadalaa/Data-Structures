using System; 

namespace ListImplementaion {
    internal class ListNode<T> {
        public T data {get; set;}
        public ListNode<T> next {get; set;}
    }
    internal class List<T> {
        ListNode<T> head; 
        int siz; 
        public List() {
            siz = 0; 
            head = null; 
        }
        internal void Insert(int pos, T data) {
            ListNode<T> node = new ListNode<T>();
            node.data = data;
            node.next = null; 

            if (pos == 0) {
                node.next = head;
                head = node;
            } else {
                ListNode<T> iterNode = new ListNode<T>();
                iterNode = head; 
                for(int i = 0; i < pos - 1; ++i) {
                    iterNode = iterNode.next; 
                }
                node.next = iterNode.next;
                iterNode.next = node;
            }

            siz++; 
        }
        internal T Delete(int pos) {
            ListNode<T> node = new ListNode<T>();
            T deleted_data; 

            if (pos == 0) {
                deleted_data = head.data; 
                node = head.next;
                head = null; 
                head = node; 
            } else {
                ListNode<T> iterNode = new ListNode<T>();
                iterNode = head; 
                for(int i = 0; i < pos - 1; ++i) {
                    iterNode = iterNode.next; 
                }
                deleted_data = iterNode.next.data;
                node = iterNode.next.next; 
                iterNode.next = null; 
                iterNode.next = node; 
            }
            siz--; 

            return deleted_data;
        }
        internal T Retrieve(int pos) {
            ListNode<T> iterNode = new ListNode<T>();
            iterNode = head; 
            for(int i = 0; i < pos; ++i) {
                iterNode = iterNode.next; 
            }
            
            return iterNode.data; 
        }
        internal void Replace(int pos, T data) {
            ListNode<T> iterNode = new ListNode<T>();
            iterNode = head; 
            for(int i = 0; i < pos; ++i) {
                iterNode = iterNode.next; 
            }
            iterNode.data = data; 
        }
        internal bool Empty() {
            return siz == 0; 
        }
        internal int Full() {
            return 0; 
        }
        internal int Size() {
            return siz; 
        }
        internal void Clear() {
            ListNode<T> node = new ListNode<T>();
            while(head != null) {
                node = head.next; 
                head = null; 
                head = node; 
            }
            siz = 0; 
        }
        internal void Print() {
            ListNode<T> node = new ListNode<T>();
            node = head;
            for (int i = 0; i < siz; ++i) {
                Console.Write($"{head.data} ");
                head = head.next;
            }
            head = node; 
        }
    }
    class Program {
        static void Main(string[] args) {
            List<int> l1 = new List<int>(); 
            l1.Insert(0, 0); 
            l1.Insert(1, 1); 
            l1.Insert(2, 2);
            l1.Insert(3, 3); 
            l1.Insert(4, 4); 
            l1.Insert(5, 5); 
            l1.Insert(6, 6); 
            l1.Insert(7, 7); 
            l1.Insert(8, 8); 
            l1.Insert(9, 9); 
            l1.Insert(10, 2); 
            l1.Print();

            Console.WriteLine("\n" + l1.Retrieve(1)); 
            l1.Replace(l1.Size() - 1, 37);
            l1.Print();
            Console.WriteLine("\n" + l1.Full()); 
            l1.Clear();
            Console.WriteLine(l1.Empty()); 
            l1.Insert(0, 0); 
            l1.Insert(1, 1); 
            l1.Insert(2, 2);
            l1.Insert(3, 3); 
            l1.Delete(2);
            l1.Print();
        }
    }
}