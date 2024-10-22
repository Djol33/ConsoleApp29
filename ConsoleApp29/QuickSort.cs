using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class QuickSort
    {
        static void z()
        {
            int[] array = { 34, 7, 23, 32, 5, 62,65,345,8,25,8,132,3,3 };
            Console.WriteLine("Original array: " + string.Join(", ", array));

            QuickSorta(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array: " + string.Join(", ", array));
        }

        // Quick Sort method
        static void QuickSorta(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int pi = Partition(arr, low, high);
                Console.WriteLine(pi);
                // Recursively sort the partitions
                QuickSorta(arr, low, pi - 1);  // Before pi
                QuickSorta(arr, pi + 1, high); // After pi
            }
        }

        // Partition method to place the pivot in the correct position
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Choose the rightmost element as the pivot
            int i = (low - 1); // Pointer for the smaller element

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (arr[j] <= pivot)
                {
                    i++; // Increment the pointer for the smaller element
                    Swap(ref arr[i], ref arr[j]); // Swap
                }
            }
            Swap(ref arr[i + 1], ref arr[high]); // Swap the pivot element with the element at i + 1
            return i + 1; // Return the partition index
        }

        // Swap method to swap two elements
        static void Swap(ref int a, ref int b)
        {
            
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
