using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MergeSorting
{
    /*Divide and Conquer rule. Sort two halves, merge and then sort the merged result.
     * 
     *Time Complexity:
     *      Best Case-> 0(N log N)
     *      Average Case-> 0(N log N)
     *      Worst Case-> 0(N log N)
     *      
     *Space Complexity:
     *      O(n)
     *      
     *Use Cases:
     *      1. Sort large data sets
     *      2. Finding the median of an array
     *      3. External sorting when a data set is too large.
     */
    public MergeSorting()
    {
        Console.WriteLine("***Merge Sort Algorithm***");
    }

    public static void Merge(int[] arr, int left, int mid, int right)
    {
        //function to merge.
        int halfOneSize = mid - left + 1;
        int halfTwoSize = mid - right;

        int[] leftHalfArr = new int[halfOneSize];
        int[] rightHalfArr = new int[halfTwoSize];
        int i, j; //loop variables for handling indexes.

        for (i = 0; i < halfOneSize; ++i)
        {
            leftHalfArr[i] = arr[left + i];
        }
        for (j = 0; j < halfTwoSize; ++j)
        {
            rightHalfArr[j] = arr[mid + 1 + j];
        }

        //now let's merge.
        i = 0; j = 0;

        int k = left;

        while (i < halfOneSize && j < halfTwoSize)
        {
            if (leftHalfArr[i] <= rightHalfArr[j])
            {
                arr[k] = leftHalfArr[i];
                i++;
            }
            else
            {
                arr[k] = rightHalfArr[j];
                j++;
            }
            k++;
        }

        while (i < halfOneSize)
        {
            arr[k] = leftHalfArr[i];
            i++; k++;
        }
        while (j < halfTwoSize)
        {
            arr[k] = rightHalfArr[j];
            j++; k++;
        }
    }

    public static void Sort(int[] arr, int start, int end)
    {
        ///call using Sort(arr, x, n - 1)
        if (start < end)
        {
            int midPoint = start + (end - start) / 2;

            Sort(arr, start, midPoint);
            Sort(arr, midPoint + 1, end);
            Merge(arr, start, midPoint, end);
            Console.WriteLine("Merge Sorting Complete!");
        }
    }
}