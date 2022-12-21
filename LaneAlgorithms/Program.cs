namespace LaneAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BigO week1 = new BigO();

            week1.SayFirstItem(week1.numbers);
            week1.SumOfAllItems(week1.numbers);
            week1.SumOfAllDifferences(week1.numbers);

            string[] letters = { "A", "B", "C", "D", "E", "F", "G" };

            //Shuffler.Shuffle<string>(letters);
            Shuffler.Shuffle<string>(letters);

            foreach (string s in letters)
            {
                Console.WriteLine(s + " ");
            }

            DataStructures.Demo();

            Sorting.Demo();

            Search.Demo();

            Trees.Demo();

            Console.ReadKey();
            
        }
    }
}