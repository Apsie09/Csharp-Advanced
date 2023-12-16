internal class Program
{
    private static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if (dimensions.Length < 2)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        else
        {
            int rows = dimensions[0];
            int cols = dimensions[1];

            // Read matrix characters
            char[][] matrix = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            }

            int br = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i][j] == matrix[i][j + 1] && matrix[i][j] == matrix[i + 1][j] && matrix[i][j] == matrix[i + 1][j + 1])
                    {
                        br++;
                    }
                }
            }

            Console.WriteLine(br);
        }



    }
}