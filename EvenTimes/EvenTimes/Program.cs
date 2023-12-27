internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, int> numbers = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (!numbers.ContainsKey(input))
            {
                numbers.Add(input, 0);
            }
            numbers[input]++;
        }



        foreach (var (key, value) in numbers)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine(key);
                break;
            }
        }

    }
}