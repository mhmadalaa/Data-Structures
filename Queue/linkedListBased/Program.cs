using System; 

namespace QueueImplementaion {
    class QueueNode<T> {
        public T data {get; set;}
        public QueueNode<T> next {get; set;}
    }
    class Queue<T> {
        QueueNode<T> front = new QueueNode<T>();
        QueueNode<T> rare = new QueueNode<T>();
        int siz; 

        public Queue() {
            front = null; 
            rare = null; 
            siz = 0; 
        }
        internal void Insert(T data) {
            QueueNode<T> new_node = new QueueNode<T>();
            if (front == null) {
                front = new_node; 
            } else {
                rare.next = new_node; 
            } 
            rare = new_node;
            siz++; 
        }
        internal bool Full() {
            return false; 
        }
        internal T Pop() {
            T top = front.data; 
            front = front.next; 
            if (front == null) { 
                rare = null;
            } 
            siz--; 
            return top; 
        }
        internal bool Empty() {
            return siz == 0; 
        }
        internal T Top() {
            return front.data; 
        }
        internal int Size() {
            return siz;
        }
        internal void Clear() {
            QueueNode<T> queueNode = new QueueNode<T>();
            QueueNode<T> nextNode = new QueueNode<T>();
            queueNode = front; 
            while(front != null) {
                queueNode = front; 
                nextNode = front.next; 
                queueNode = null; 
                front = nextNode; 
            }
            siz = 0; 
        }
        public void Print() {
            QueueNode<T> queueNode = new QueueNode<T>();
            queueNode = front;
            for (int i = 0; i < siz; ++i) {
                Console.Write($"{queueNode.data} ");
                queueNode = queueNode.next;
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            // test int Queue
            Queue<int> q = new Queue<int>();
            q.Insert(29);
            q.Insert(3);
            q.Insert(44);
            q.Insert(44);
            q.Insert(44);
            q.Insert(1);
            
            q.Print();
            Console.WriteLine("\n" + q.Top());
            Console.WriteLine(q.Size() + "\n");

            // // test char Queue
            Queue<char> qch = new Queue<char>();
            qch.Insert('a');
            qch.Insert('a');
            qch.Insert('c');
            qch.Insert('D');
            qch.Insert('w');
            qch.Insert('Z');
            qch.Print();
            Console.WriteLine("\n" + qch.Top());
            Console.WriteLine(qch.Size());
        }
    }
}
