using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class QuickSorting
{ 
    /*
     * 
     * Time Complexity:
     *      Best Case-> 0(N log N)
     *      Average Case-> 0(N log N)
     *      Worst Case-> O(N^2)
     */
    public QuickSorting()
    {
        Console.WriteLine("***Quick Sort Algorithm***");
    }

    public static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = QPartition(arr, left, right);
            Sort(arr, left, pivot - 1);
            Sort(arr, pivot + 1, right);
        }
    }
    private static int QPartition(int[] arr, int left, int right)
    {
        int pivot = arr[right]; //choose a pivot.

        int index = left - 1;

        for (int x = left; x <= right - 1; x++)
        {
            if (arr[x] < pivot)
            {
                index++;
                Swap(arr, index, x);
            }
        }
        Swap(arr, index + 1, right);
        return (index + 1);
    }
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}