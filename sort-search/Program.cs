using System; 

namespace Sorting_Searching {
    public class Sort {
        // Bubble sort code
        public int[] bubbleSort(int[] arr) {
            for (int i = 1; i < arr.Length; ++i) {
                for (int j = 0; j <= arr.Length - i - 1; ++j) {
                    if (arr[j] > arr[j + 1]) {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); 
                    }
                }
            }

            return arr;
        }

        // selection sort code
        public int[] selectionSort(int[] arr) {
            for (int i = 0; i < arr.Length; ++i) {
                int min_idx = i; 
                for (int j = i + 1; j < arr.Length; ++j) {
                    if (arr[j] < arr[min_idx]) min_idx = j; 
                }
                (arr[i], arr[min_idx]) = (arr[min_idx], arr[i]); 
            }

            return arr;
        }

        // insertion sort code
        public int[] insertionSort(int[] arr) {
            int key, j;
            for (int i = 1; i < arr.Length; ++i) {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > key) {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            return arr; 
        }

        // shell sort
        public int[] shellSort(int[] arr) {
            int n = arr.Length; 
            int key, j;
            for (int interval = n / 2; interval > 0; interval /= 2) {
                for (int i = interval; i < n; ++i) {
                    key = arr[i]; 
                    j = i - interval;
                    while (j >= 0 && arr[j] > key) {
                        arr[j + interval] = arr[j];
                        j -= interval;
                    }
                    arr[j + interval] = key; 
                }
            }

            return arr;
        }
    }
    public class Search {
        internal int linearSearch(int[] arr, int val) {
            for (int i = 0; i < arr.Length; ++i) if (arr[i] == val) return i; 
            return -1; 
        }
        internal int binarySearch(int[] arr, int val) {
            int low = 0, high = arr.Length - 1; 
            while (low <= high) {
                int mid = low + (high - low) / 2; 
                if (arr[mid] == val) return mid; 

                if (arr[mid] < val) low = mid + 1; 
                else high = mid - 1; 
            }
            return -1; 
        }
    }
    public class Test {
        static void Main(string[] args) {
            Sorting(); 

            Searching(); 
        }
        static void Searching() {
            int[] arr = new int[] {32, 23, 11, 2}; 

            Sort sort = new Sort(); 
            sort.insertionSort(arr); 
            
            Search search = new Search(); 
            Console.WriteLine(search.linearSearch(arr, 11)); 
            Console.WriteLine(search.binarySearch(arr, 11)); 
            Console.WriteLine(search.linearSearch(arr, 99)); 
            Console.WriteLine(search.binarySearch(arr, 99)); 
        }
        static void Sorting() {
            Sort sort = new Sort(); 

            int[] arr = new int[] {32, 23, 11, 2}; 
            // hint: array in C# passed by reference by default 

            foreach (var it in arr) Console.Write($"{it} "); 
            Console.WriteLine();
            int[] shellArr = sort.shellSort(arr); 
            foreach (var it in shellArr) Console.Write($"{it} "); 
            Console.WriteLine("\n");        

            foreach (var it in arr) Console.Write($"{it} "); 
            Console.WriteLine();
            int[] bubbleArr = sort.bubbleSort(arr); 
            foreach (var it in bubbleArr) Console.Write($"{it} "); 
            Console.WriteLine("\n");
            
            foreach (var it in arr) Console.Write($"{it} "); 
            Console.WriteLine();
            int[] selectionArr = sort.selectionSort(arr); 
            foreach (var it in selectionArr) Console.Write($"{it} "); 
            Console.WriteLine("\n");

            foreach (var it in arr) Console.Write($"{it} "); 
            Console.WriteLine();
            int[] insertionsArr = sort.insertionSort(arr); 
            foreach (var it in insertionsArr) Console.Write($"{it} "); 
            Console.WriteLine("\n");
        }
    }

}