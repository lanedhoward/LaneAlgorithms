using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public static class Swapper
    {

        public static void SwapValuesAtIndices<T>(T[] objects, int i, int j)
        {
            T temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
