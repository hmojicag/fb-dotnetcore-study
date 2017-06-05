using System;

namespace Sorting {
  public class ArraySorting {

    public static void sortArrayWithSelectionSort(int[] array) {
      int lastIndex = array.Length - 1;
      for (int i = 0; i <= lastIndex; i++) {
        int minIndex = findMinIndex(array, i, lastIndex);
        if (minIndex != i) {
          //Swap values
          int a = array[i];
          array[i] = array[minIndex];
          array[minIndex] = a;
        }
      }
    }

    private static int findMinIndex(int[] array, int startIndex, int endIndex) {
      int minIndex = startIndex;
      int minVal = array[startIndex];
      for(int i = startIndex; i <= endIndex; i++) {
        if(array[i] < minVal) {
          minVal = array[i];
          minIndex = i;
        }
      }
      return minIndex;
    }

  }
}
