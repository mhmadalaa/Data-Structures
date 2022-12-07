using System; 

namespace ListImplementaion {
    internal class List<T> {
        public List(int MAXLIST) {
            
        }
        internal void Insert(int pos, T data) {
           
        }
        internal void Delete(int pos) {
             
        }
        internal T Retrieve(int pos) {
            
        }
        internal void Replace(int pos, T data) {
            
        }
        internal bool Empty() {
            ; 
        }
        internal bool Full() {
             
        }
        internal int Size() {
             
        }
        internal void Clear() {
             
        }
        internal void Print() {
            
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