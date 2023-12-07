internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        int max = 0;
        int min = 0;

        if (N >= 1 && N <= 105)
        {
            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (input[0] == 1 && input[1] >= 1 && input[1] <= 109)
                {
                    stack.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    stack.Pop();
                }
                else if (input[0] == 3 && stack.Count > 0)
                {
                    max = FindMax(stack);
                }
                else if (input[0] == 4 && stack.Count > 0)
                {
                    min = FindSmallest(stack);
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(string.Join(", ", stack));
        }
    }

    static int FindSmallest(Stack<int> stack)
    {
        if (stack.Count == 0)
        {
            return 0;
        }

        int min = int.MaxValue;

        foreach (var item in stack)
        {
            if (item < min)
            {
                min = item;
            }
        }
        return min;
    }

    static int FindMax(Stack<int> stack)
    {
        if (stack.Count == 0)
        {
            return 0;
        }

        int max = int.MinValue;

        foreach (var item in stack)
        {
            if (item > max)
            {
                max = item;
            }
        }
        return max;
    }
}