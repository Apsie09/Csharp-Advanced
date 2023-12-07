internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int S = int.Parse(input[1]);
        int X = int.Parse(input[2]);

        int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < N; i++)
        {
            queue.Enqueue(sequence[i]);
        }

        for (int i = 0; i < S; i++)
        {
            queue.Dequeue();
        }

        if (queue.Contains(X))
        {
            Console.WriteLine("true");
        }
        else
        {
            if (queue.Count > 0)
            {
                int min = FindSmallest(queue);
                Console.WriteLine(min);
            }
            else { Console.WriteLine("0"); }
        }


    }

    static int FindSmallest(Queue<int> queue)
    {
        int smallest = int.MaxValue;

        foreach (int i in queue)
        {
            if (smallest > i)
            {
                smallest = i;
            }
        }

        return smallest;
    }
}