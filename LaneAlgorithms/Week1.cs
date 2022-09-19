using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneAlgorithms
{
    public class Week1
    {
        public List<int> numbers;

        public Week1()
        {
            numbers = new List<int>();

            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(r.Next(0, 100));
            }

        }

        /// <summary>
        /// O(1) or constant 
        /// because it does the same amount of actions no matter the n
        /// </summary>
        /// <param list="n"></param>
        public void SayFirstItem(List<int> n)
        {
            Console.WriteLine("The first item is " + n[0]);
        }
        
        /// <summary>
        /// O(n) or linear
        /// because it has to do an action for every n
        /// </summary>
        /// <param name="n"></param>
        public void SumOfAllItems(List<int> n)
        {
            int sum = 0;
            foreach (int i in n)
            {
                sum += i;
            }
            Console.WriteLine("The sum of all the items is " + sum);
        }
        /// <summary>
        /// O(n^2) or quadratic
        /// because it loops through n times, and n times for each n. so n * n or n^2.
        /// </summary>
        /// <param name="n"></param>
        public void SumOfAllDifferences(List<int> n)
        {
            int sum = 0;
            foreach (int i in n)
            {
                // for each number
                foreach (int j in n)
                {
                    // find the difference with every number
                    // and add it to the sum
                    sum += i - j;
                }
            }
            Console.WriteLine("The sum of all the differences is " + sum);
        }

    }
}
