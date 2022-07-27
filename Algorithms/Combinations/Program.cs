using System;

namespace Combinations
{
    class Program
    {
        /// <summary>
        /// https://www.geeksforgeeks.org/print-all-possible-combinations-of-r-elements-in-a-given-array-of-size-n/
        /// </summary>
        /// <param name="arr">Input elements</param>
        /// <param name="data">Current combination</param>
        /// <param name="start">Start index of arr</param>
        /// <param name="end">End index of arr</param>
        /// <param name="index">Current index in data</param>
        /// <param name="r">Size of combination</param>
        static void GetCombinations<T>(T []arr, T []data,
                                    int start, int end,
                                    int index, int r)
        {
            // Current combination is
            // ready to be printed,
            // print it
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }
    
            // replace index with all
            // possible elements. The
            // condition "end-i+1 >=
            // r-index" makes sure that
            // including one element
            // at index will make a
            // combination with remaining
            // elements at remaining positions
            for (int i = start; i <= end &&
                    end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                GetCombinations(arr, data, i + 1,
                                end, index + 1, r);
            }
        }
 
        // The main function that prints
        // all combinations of size r
        // in arr[] of size n. This
        // function mainly uses combinationUtil()
        static void PrintCombination<T>(T []arr,
                                    int n, int r)
        {
            // A temporary array to store
            // all combination one by one
            T []data = new T[r];
    
            // Print all combination
            // using temporary array 'data[]'
            GetCombinations(arr: arr, data: data, start:0,
                            end: n - 1, index: 0, r: r);
        }
        static void Main(string[] args)
        {
            string []arr = {"single", "fox", "from", "another", "box"};
            int r = 2;
            int n = arr.Length;
            PrintCombination<string>(arr, n, r);
        }
    }
}
