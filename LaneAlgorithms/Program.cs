namespace LaneAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Week1 week1 = new Week1();

            week1.SayFirstItem(week1.numbers);
            week1.SumOfAllItems(week1.numbers);
            week1.SumOfAllDifferences(week1.numbers);
        }
    }
}