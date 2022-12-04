using System; 

namespace StackImplementation {
    internal class Stack<T> {
        int MAXSTACK; 
        int top; 
        T[] stack;

        public Stack(int MAXSTACK) {
            this.MAXSTACK = MAXSTACK;
            stack = new T[MAXSTACK]; 
            top = -1; 
        }
        internal void Push(T data) {
            stack[++top] = data;
        }
        internal bool Full() {
            return top >= MAXSTACK; 
        }
        internal T Pop() {
            return stack[top--];  
        }
        internal bool Empty() {
            return top < 0; 
        }
        internal T Top() {
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
            // test int stack
            Stack<int> sk = new Stack<int>(10); 

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


            // test string stack
            Stack<string> str_sk = new Stack<string>(10);
            str_sk.Push("ahi");  
            str_sk.Push("echo"); 
            str_sk.Push("sys"); 
            str_sk.Print(); 

            if (!str_sk.Empty()) str_sk.Pop(); 
            str_sk.Print(); 

            if (!str_sk.Empty()) Console.WriteLine(str_sk.Top());

            if (!str_sk.Full()) {
                str_sk.Push("cd .."); 
                str_sk.Push("cd ecpc/acpc/icpc/winner "); 
            }
            str_sk.Print();
        }
    }
}       
