using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing SelectionSort");
            int[] array1 = new int[] {10, 4, 30, 600, 10, 0, 3, 9, 14, 100};
            Console.Write("Not Sorted: ");
            printArray(array1);
            ArraySorting.sortArrayWithSelectionSort(array1);
            Console.Write("\nSorted: ");
            printArray(array1);
            Console.WriteLine("");
        }

        public static void printArray(int[] array) {
          Console.Write("{");
          Console.Write(array[0]);
          for(int i = 1; i < array.Length; i++) {
            Console.Write(", ");
            Console.Write(array[i]);
          }
          Console.Write("}");
        }
    }
}
