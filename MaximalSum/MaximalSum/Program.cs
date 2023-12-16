internal class Program
{
    private static void Main(string[] args)
    {
        int[] inputDimenstion = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int N = inputDimenstion[0];
        int M = inputDimenstion[1];

        int[,] matrix = new int[N, M];

        for (int row = 0; row < N; row++)
        {
            int[] inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int col = 0; col < M; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;

        for (int i = 0; i < N - 2; i++)
        {
            for (int j = 0; j < M - 2; j++)
            {
                var sum = 0;

                for (int x = i; x < i + 3; x++)
                {
                    for (int y = j; y < j + 3; y++)
                    {
                        sum += matrix[x, y];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        Console.WriteLine("Sum = " + maxSum);

        for (int i = maxRow; i < maxRow + 3; i++)
        {
            for (int j = maxCol; j < maxCol + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}