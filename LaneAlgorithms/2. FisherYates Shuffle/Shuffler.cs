using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public static class Shuffler
    {
        private static Random random = new Random();

        public static void Shuffle<T>(T[] objects) //improvement 1: made the shuffle method generic. an array shouldn't be concerned with shuffling itself
        {
            for(int i = objects.Length -1; i > 0; i -= 1) //improvement 2: i -= 1 is more readable than i--
            {
                int j = GetRandomNumberBetweenZeroAnd(i);
                Swapper.SwapValuesAtIndices<T>(objects, i, j);
            }
        }
        public static void ShuffleAlternative<T>(T[] objects) 
        {
            for (int i = 0; i > objects.Length - 2; i += 1)
            {
                int j = GetRandomNumberBetweenZeroAnd(objects.Length - i)-1;
                Swapper.SwapValuesAtIndices<T>(objects, i, i + j);
            }
        }

        private static int GetRandomNumberBetweenZeroAnd(int i) //i like the way this method name reads like english when used
        {
            return random.Next(i + 1);
        }

    }
}
