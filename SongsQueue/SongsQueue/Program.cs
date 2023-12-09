internal class Program
{
    private static void Main(string[] args)
    {
        string[] songs = Console.ReadLine().Split(", ");

        Queue<string> queue = new Queue<string>(songs);


        while (queue.Count > 0)
        {
            string[] command = Console.ReadLine().Split();
            if (command[0] == "Play")
            {
                PlaySong(queue);
            }
            else if (command[0] == "Add")
            {
                AddSong(queue, string.Join(" ", command[1..]));
            }
            else if (command[0] == "Show")
            {
                ShowSong(queue);
            }
        }
        Console.WriteLine("No more songs!");
    }

    private static void PlaySong(Queue<string> queue)
    {
        if (queue.Count > 0)
        {
            queue.Dequeue();
        }
    }

    private static void AddSong(Queue<string> queue, string song)
    {
        if (queue.Contains(song))
        {
            Console.WriteLine(song + " is already contained!");
        }
        else
        {
            queue.Enqueue(song);
        }
    }

    private static void ShowSong(Queue<string> queue)
    {
        Console.WriteLine(string.Join(", ", queue));
    }
}