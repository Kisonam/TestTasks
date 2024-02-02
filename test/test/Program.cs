internal class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<int> numbers = new List<int> { 4, 2 ,6 };
        IEnumerable<int> squares = new List<int> { 4, 36 , 16 };

        bool result = TestForSquares(numbers, squares);
        Console.WriteLine(result);

        Console.ReadLine();
    }

    public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
    {
        if (numbers.Count() != squares.Count())
            return false;

        numbers = numbers.OrderBy(x => x);
        squares = squares.OrderBy(x => x);

        for (int i = 0; i < numbers.Count(); i++)
        {
            if (squares.ElementAt(i) != numbers.ElementAt(i) * numbers.ElementAt(i))
            {
                return false;
            }
        }

        return true;
    }
}