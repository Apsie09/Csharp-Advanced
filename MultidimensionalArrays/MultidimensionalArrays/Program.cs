using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        string firstLine = Console.ReadLine();
        string[] firstLineParts = firstLine.Split(", ");
        int row = int.Parse(firstLineParts[0]);
        int col = int.Parse(firstLineParts[1]);

        int[,] table = new int[row, col];

        for (int i = 0; i < row; i++)
        {
            string[] lineParts = Console.ReadLine().Split(" ");

            for (int j = 0; j < col; j++)
            {
                table[i, j] = int.Parse(lineParts[j]);
            }
        }

        string[] subMatrixLineParts = Console.ReadLine().Split(", ");
        int subRows = int.Parse(subMatrixLineParts[0]);
        int subCols = int.Parse(subMatrixLineParts[1]);


        long maxSum = long.MinValue;
        int maxsumRow = 0;
        int maxsumCol = 0;

        for (int i = 0; i < table.GetLength(0) - subRows + 1; i++)
        {
            for (int j = 0; j < table.GetLength(1) - subCols + 1; j++)
            {
                int sum = 0;

                for (int k = 0; k < subRows; k++)
                {
                    for (int l = 0; l < subCols; l++)
                    {
                        sum += table[i + k, j + l];
                    }
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxsumRow = i;
                    maxsumCol = j;
                }
            }
        }


        for (int i = maxsumRow; i < maxsumRow + subRows; i++)
        {
            for (int j = maxsumCol; j < maxsumCol + subCols; j++)
            {
                Console.Write(table[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine(maxSum);
    }
}