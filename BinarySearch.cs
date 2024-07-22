using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BinarySearching
{
    /*Repeatedly divides the search interval in half to find a target value. We aim to reduce the time complex. to O (log N).
     *Note that the data structure being searched must be Sorted and time taken must be constant.
     *If the target value is on one half then the algorithm only searches that half, if the target is not the midPoint.
     *There are 2 approaches: 
     *      1. Iterative Binary Searching
     *      2. Recursive Binary Searching
     *      
     *Time Complexity:
     *      1. Iterative:
         *          0(log N)

         *  2. Recursive:
         *          Best Case-> 0(1)
     *              Average Case-> 0(log N)
     *              Worst Case-> 0(log N)
     *      
     *Space Complexity:
     *      1. Iterative:
         *          O(1)
         *      
         *  2. Recursive:
         *          O(1) excluding recursive stack and
     *              O(n) when including recursive stack.
     *      
     *Use Cases:
     *      1. Building block for ML algorithms, training neural networks, etc..
     *      2. Computer Graphics such as: Texture mapping and/or ray tracing.
     *      3. Searching in a database.
     */
    public BinarySearching()
    {
        Console.WriteLine("***Binary Search Algorithm***");
    }

    public static int IterativeBinarySearch(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end) 
        { 
            int midPoint = start + (end - start) / 2;

            if (arr[midPoint] == target)
                return midPoint;

            if (arr[midPoint] < target)
                start = midPoint + 1;

            else
                end = midPoint - 1;
        }
        return -1; //no element present.
    }
    public static int RecursiveBinarySearch(int[] arr, int start, int end, int target)
    {
        //call using RecursiveBinarySearch(arr, 0, N-1, targetNumber);
        if (start <= end)
        {
            int midPoint = start + ((end - start) / 2);

            if (arr[midPoint] == target)
                return midPoint;
            if (arr[midPoint] > target)
                return RecursiveBinarySearch(arr, start, midPoint - 1, target);
            else
                return RecursiveBinarySearch(arr, midPoint + 1, end, target);
        }
        return -1;
    }
}