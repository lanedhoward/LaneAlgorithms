using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace LaneAlgorithms
{ 
    public class DataStructures
    {
        public static void Demo()
        {
            string path = "../../../Data/scores.txt";

            // An array is a data structure that stores set of data of a fixed size.
            // Arrays often hold data together in memory, which makes random access and iterating through the data very efficient.
            // Arrays can have multiple dimensions (up to 32).
            // And each dimension can have a different size, which makes it a jagged array.
            string[] array = FileLoader.LoadTextAsArray(path);

            // A dictionary, or a map, is a data structure that stores a related set of keys and values.
            // You can look up the value for a key very efficiently, at O(1) on average.
            // However, since keys are not ordered, lookups can take O(n) in the worst case.
            // Also, looking up the key for a given value requires searching through the entire list.
            // Dictionaries are very flexible, since almost any type can be used for your keys and values
            Dictionary<int, string> dictionary = FileLoader.LoadTextAsDictionary(path);

            // A stack is a data structure without random access.
            // Instead, data is added and accessed on a First In, Last Out (FILO) basis.
            // Stacks are very efficient, conducting all operations in O(1) time.
            // They are often used to keep track of nested tasks, such as the call stack, or nodes during a depth-first search.
            Stack<string> stack = FileLoader.LoadTextAsStack(path);

            // A queue is a similar data structure to a stack.
            // However, queues use a First In, First Out (FIFO) order.
            // Queues are useful for keeping track of tasks that need to be completed in the order they were added.
            // Queues are used to store web server requests, CPU processes, and nodes during a breadth-first search, for example.
            Queue<string> queue = FileLoader.LoadTextAsQueue(path);

        }
        
    }

    public static class FileLoader
    {
        public static string[] LoadTextAsArray(string path)
        {
            IEnumerable<string> text = File.ReadLines(path);
            int totalLines = text.Count();

            string[] output = new string[totalLines];

            IEnumerator<string> enumerator = text.GetEnumerator();
            //enumerator.Reset();

            for (int i = 0; i < totalLines; i++)
            {
                output[i] = enumerator.Current;
                enumerator.MoveNext();
            }

            return output;
        }

        public static Dictionary<int,string> LoadTextAsDictionary(string path)
        {
            IEnumerable<string> text = File.ReadLines(path);
            int totalLines = text.Count();

            Dictionary<int, string> output = new Dictionary<int, string>();

            IEnumerator<string> enumerator = text.GetEnumerator();
            //enumerator.Reset();

            for (int i = 0; i < totalLines; i++)
            {
                output.Add(i, enumerator.Current);                
                enumerator.MoveNext();
            }

            return output;
        }

        public static Stack<string> LoadTextAsStack(string path)
        {
            IEnumerable<string> text = File.ReadLines(path);
            int totalLines = text.Count();

            Stack<string> output = new Stack<string>();

            IEnumerator<string> enumerator = text.GetEnumerator();
            //enumerator.Reset();

            for (int i = 0; i < totalLines; i++)
            {
                output.Push(enumerator.Current);
                enumerator.MoveNext();
            }

            return output;
        }

        public static Queue<string> LoadTextAsQueue(string path)
        {
            IEnumerable<string> text = File.ReadLines(path);
            int totalLines = text.Count();

            Queue<string> output = new Queue<string>();

            IEnumerator<string> enumerator = text.GetEnumerator();
            //enumerator.Reset();

            for (int i = 0; i < totalLines; i++)
            {
                output.Enqueue(enumerator.Current);
                enumerator.MoveNext();
            }

            return output;
        }
    }
}
