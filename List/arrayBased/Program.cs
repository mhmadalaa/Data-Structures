using System; 

namespace ListImplementaion {
    internal class List<T> {
        int MAXLIST; 
        T[]? list; 
        int siz; 
        int idx; 
        
        public List(int MAXLIST) {
            this.MAXLIST = MAXLIST; 
            this.list = new T[MAXLIST];
            siz = 0; 
            idx = 0; 
        }
        internal void Insert(int pos, T data) {
            for (int i = siz - 1; i >= pos; --i) {
                list[i + 1] = list[i]; 
            }
            list[pos] = data;
            siz++; 
        }
        internal void Delete(int pos) {
            for (int i = pos + 1; i <= siz - 1; ++i) {
                list[i - 1] = list[i];
            }
            siz--; 
        }
        internal T Retrieve(int pos) {
            return list[pos];
        }
        internal void Replace(int pos, T data) {
            list[pos] = data; 
        }
        internal bool Empty() {
            return siz == 0; 
        }
        internal bool Full() {
            return siz >= MAXLIST; 
        }
        internal int Size() {
            return siz; 
        }
        internal void Clear() {
            siz = 0; 
        }
        internal void Print() {
            for (int i = 0; i < siz; ++i) {
                Console.Write($"{list[i]} "); 
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            List<int> l1 = new List<int>(10); 
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
            // l1.Insert(10, 2); 
            l1.Print();

            Console.WriteLine("\n" + l1.Retrieve(7)); 
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