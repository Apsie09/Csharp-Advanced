internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n,n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                arr[i, j] = int.Parse(input[j]);
            }
        }

        int sumPrimary = 0;
        int sumSecondary = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(i == j)
                {
                    sumPrimary += arr[i, j];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == n - 1 - i)
                {
                    sumSecondary += arr[i, j];
                }
            }
        }

        int finalSum = Math.Abs(sumPrimary - sumSecondary);

        Console.WriteLine(finalSum);
    }
}