using System; 

namespace QueueImplementaion {
    internal class Queue<T> {
        int front, rear;
        int MAXQUEUE; 
        int siz; 
        T[] queue;

        public Queue(int MAXQUEUE) {
            siz = 0; 
            front = 0; 
            rear = -1; 
            this.MAXQUEUE = MAXQUEUE;
            queue = new T[MAXQUEUE];
        }
        internal void Insert(T data) {
            rear = (rear + 1) % MAXQUEUE;
            queue[rear] = data;
            siz += Convert.ToInt16(siz < MAXQUEUE); 
        }
        internal bool Full() {
            return siz >= MAXQUEUE;
        }
        internal T Pop() {
            T deleted_ele = queue[front]; 
            front = (front + 1) % MAXQUEUE;
            siz -= Convert.ToInt16(siz > 0); 
            return deleted_ele;
        }
        internal bool Empty() {
            return siz == 0; 
        }
        internal T Top() {
            return queue[front]; 
        }
        internal int Capacity() {
            return siz;
        }
        internal int Size() {
            return MAXQUEUE;
        }
        internal void Clear() {
            front = 0;
            rear = -1; 
        }
        public void Print() {
            for (int i = front, s = 0; s < siz; s++) {
                Console.Write($"{queue[i]} ");
                i = (i + 1) % MAXQUEUE;
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            // test int Queue
            Queue<int> q = new Queue<int>(10);
            q.Insert(29);
            q.Insert(3);
            q.Insert(44);
            q.Insert(44);
            q.Insert(44);
            q.Insert(1);
            
            q.Print();
            Console.WriteLine("\n" + q.Top());
            Console.WriteLine(q.Capacity() + "\n");

            // test char Queue
            Queue<char> qch = new Queue<char>(10);
            qch.Insert('a');
            qch.Insert('a');
            qch.Insert('c');
            qch.Insert('D');
            qch.Insert('w');
            qch.Insert('Z');
            qch.Print();
            Console.WriteLine("\n" + qch.Top());
            Console.WriteLine(qch.Capacity());
        }
    }
}