using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public class Search
    {
        public static void Demo()
        {
            string shortpath = "../../../Data/shortscores.txt";
            string longpath = "../../../Data/scores.txt";
            int[] array;

            array = Sorting.LoadInts(longpath);
            // linear works on any array
            int linearResult = LinearSearch(array, 28);
            
            
            // these two require a sorted array
            Sorting.BubbleSort(array);

            int binaryResult = BinarySearch(array, 28);
            int interpolatedResult = InterpolationSearch(array, 28);
        }

        public static int LinearSearch(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x) return i;
            }

            return -1; // did not find x
        }

        public static int BinarySearch(int[] array, int x)
        {
            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == x)
                {
                    return mid;
                }
                else if (x > array[mid]) // x is on right side
                {
                    low = mid + 1;
                }
                else // x is on left side
                {
                    high = mid - 1;
                }
            }

            return -1; //didn't find x
        }

        public static int InterpolationSearch(int[] array, int x)
        {
            

            int low = 0, high = array.Length - 1;
            while (low <= high)
            {
                //int mid = (low + high) / 2;
                int pos = low + ((x - array[low]) * (high - low)) / (array[high] - array[low]);

                if (array[pos] == x)
                {
                    return pos;
                }
                else if (x > array[pos]) // x is on right side
                {
                    low = pos + 1;
                }
                else // x is on left side
                {
                    high = pos - 1;
                }
            }

            return -1; //didn't find x
        }
    }
}
