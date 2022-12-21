using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public class Heap
    {
        public static void Heapify(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                //start at new item and go up to the root
                int index = i;

                while (index != 0)
                {
                    //find parent index
                    int parentIndex = (index - 1) / 2;

                    // check if this is allowed for heap (child <= parent)
                    if (array[index] <= array[parentIndex]) { break; }

                    Swapper.SwapValuesAtIndices(array, index, parentIndex);

                    index = parentIndex;
                }

            }
        }

        public static int RemoveTopItem(int[] array, int heapLength)
        {
            //save top item
            int topItem = array[0];

            //move last item to root
            array[0] = array[heapLength - 1];

            FixHeap(array, heapLength-1);

            return topItem;
        }

        public static void FixHeap(int[] array, int heapLength)
        {
            //fix heap
            int index = 0;
            while (true)
            {
                //find children
                int child1 = 2 * index + 1;
                int child2 = 2 * index + 2;

                //ensure children aren't off the tree
                if (child1 > heapLength) child1 = index;
                if (child2 > heapLength) child2 = index;

                // if heap is fixed, we are done, so break
                if (array[index] >= array[child1] && array[index] >= array[child2])
                {
                    break;
                }

                // get index of larger child, then swap with parent
                int largerChild = (array[child1] > array[child2]) ? child1 : child2;
                Swapper.SwapValuesAtIndices(array, index, largerChild);

                //move to child node (which now holds the original parent value)
                index = largerChild;
            }
        }
    }
}
