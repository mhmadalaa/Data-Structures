using System; 

namespace StackImplementation {
    internal class Stack{
        int MAXSTACK; 
        int top; 
        int[] stack;

        public Stack(int siz) {
            MAXSTACK = siz;
            stack = new int[MAXSTACK]; 
            top = -1; 
        }
        internal void Push(int data) {
            stack[++top] = data;
        }
        internal bool Full() {
            return top >= MAXSTACK; 
        }
        internal int Pop() {
            return stack[top--];  
        }
        internal bool Empty() {
            return top < 0; 
        }
        internal int Top() {
            return stack[top];  
        }
        internal int Size() {
            return top + 1; 
        }
        internal void Clear() {
            top = -1; 
        }
        internal void Print() {
            for (int i = top; i >= 0; --i) Console.Write($"{stack[i]} "); 
            Console.WriteLine(); 
        }
    }
    class Program{
        static void Main(string[] args) {
            Stack sk = new Stack(10); 

            sk.Push(3);  
            sk.Push(4); 
            sk.Push(5); 
            sk.Print(); 

            if (!sk.Empty()) sk.Pop(); 
            sk.Print(); 

            if (!sk.Empty()) Console.WriteLine(sk.Top());

            if (!sk.Full()) {
                sk.Push(83); 
                sk.Push(24); 
            }
            sk.Print();
            
            Console.WriteLine(sk.Size());
        }
    }
}       
