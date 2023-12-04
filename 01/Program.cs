namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitFinder digitFinder = new();

            int result = digitFinder.FindRelevantSum();
            
            Console.WriteLine(result.ToString());
        }
    }
}
