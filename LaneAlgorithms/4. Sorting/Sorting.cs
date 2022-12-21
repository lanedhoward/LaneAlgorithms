using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public class Sorting
    {
        public static void Demo()
        {
            string shortpath = "../../../Data/shortscores.txt";
            string longpath = "../../../Data/scores.txt";
            int[] array;

            array = LoadInts(longpath);
            BubbleSort(array);

            array = LoadInts(longpath);
            InsertionSort(array);

            array = LoadInts(longpath);
            SelectionSort(array);

            array = LoadInts(longpath);
            HeapSort(array);

            array = LoadInts(longpath);
            QuickSort(array);

            array = LoadInts(longpath);
            MergeSort(array);
        }

        public static void BubbleSort(int[] inputArray)
        {
            bool sorted = false;
            while (sorted == false)
            {
                // assume array is sorted until it is proved that we have to go again
                sorted = true;

                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (inputArray[i] < inputArray[i-1]) //if the current number is less than the one before it, swap them
                    {
                        sorted = false;
                        Swapper.SwapValuesAtIndices(inputArray, i, i - 1);
                    }
                }
            }
        }

        public static void InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                for (int j=i+1; j > 0; j--)
                {
                    if (inputArray[j] < inputArray[j-1]) //take the number in front of i, and move it back until it is sorted behind i.
                    {
                        Swapper.SwapValuesAtIndices(inputArray, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void SelectionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                //find the smallest value in the rest of the array
                //and put it in i
                int smallestValueIndex = i;
                
                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[smallestValueIndex])
                    {
                        smallestValueIndex = j;
                    }
                }
                Swapper.SwapValuesAtIndices(inputArray, i, smallestValueIndex);
            }
        }

        public static void HeapSort(int[] inputArray)
        {
            // put the array in a max heap
            Heap.Heapify(inputArray);

            for (int i = inputArray.Length-1; i > 0; i--)
            {
                // swap the root (greatest value) at the end of the array
                Swapper.SwapValuesAtIndices(inputArray, 0, i);

                //fix the heap, now ignoring the already sorted items at the end
                Heap.FixHeap(inputArray, i - 1);
            }
        }

        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }
        public static void QuickSort(int[] array, int low, int high)
        {
            //ensure indices are right
            if (low >= high || low < 0) return;
            
            int pivotIndex = Partition(array,low,high);

            QuickSort(array, low, pivotIndex - 1); // sort left side of pivot
            QuickSort(array, pivotIndex + 1, high); // sort right side of pivot

        }
        public static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                // if the current element is <= than pivot
                if (array[j] <= pivot)
                {
                    //move index forward
                    i = i + 1;
                    //swap current element with temp pivot index
                    Swapper.SwapValuesAtIndices(array, i, j);
                }
            }
            // move pivot element to correct pivot position between smaller and larger elements
            i = i + 1;
            Swapper.SwapValuesAtIndices(array, i, high);

            return i;
        }

        public static void MergeSort(int[] array)
        {
            int[] scratch = new int[array.Length];
            MergeSort(array, scratch, 0, array.Length-1);
        }
        public static void MergeSort(int[] array, int[] scratch, int start, int end)
        {
            if (start == end) return; //if the array is only 1 item, it is sorted

            //break array into left and right halves
            int midpoint = (start + end) / 2;

            // merge sort the two halves
            MergeSort(array, scratch, start, midpoint);
            MergeSort(array, scratch, midpoint + 1, end);

            Merge(array, start, midpoint, end);

            /*
            //Merge the two sorted halves
            int left_index = start;
            int right_index = midpoint + 1;
            int scratch_index = left_index;

            while ((left_index <= midpoint) && (right_index <= end))
            {
                if (array[left_index] <= array[right_index])
                {
                    scratch[scratch_index] = array[left_index];
                    left_index += 1;
                }
                else
                {
                    scratch[scratch_index] = array[right_index];
                    right_index += 1;
                }
                scratch_index += 1;
            }

            // finish copying whichever half is not empty
            for (int i = left_index; i < midpoint; i++)
            {
                scratch[scratch_index] = array[i];
                scratch_index += 1;
            }
            for (int i = right_index; i < end; i++)
            {
                scratch[scratch_index] = array[i];
                scratch_index += 1;
            }

            //copy values back into original array
            for (int i = start; i < end; i++)
            {
                array[i] = scratch[i];
            }
            */
        }

        public static void Merge(int[] array, int low, int mid, int high)
        {
            int[] leftArray = new int[(mid - low) + 1];
            int[] rightArray = new int[(high - mid)];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[low + i];
            }
            for (int j = 0; j < rightArray.Length; j++)
            {
                rightArray[j] = array[mid + 1 + j];
            }

            int l = 0, r = 0, k = low;
            while (l < leftArray.Length && r < rightArray.Length)
            {
                if (leftArray[l] <= rightArray[r])
                {
                    array[k] = leftArray[l];
                    l++;
                }
                else
                {
                    array[k] = rightArray[r];
                    r++;
                }
                k++;
            }

            while (l < leftArray.Length)
            {
                array[k] = leftArray[l];
                l++;
                k++;
            }

            while (r < rightArray.Length)
            {
                array[k] = rightArray.Length;
                r++;
                k++;
            }
        }

        //helper methods
        public static int[] IntParseStringArray(string[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = int.Parse(arr[i]);
            }

            return result;
        }

        public static int[] LoadInts(string path)
        {
            return IntParseStringArray(FileLoader.LoadTextAsArray(path));
        }

    }
}
