internal class Program
{
    private static void Main(string[] args)
    {
        int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rackCapacity = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>(clothes);

        int racks = 1;

        int sum = 0;

        while (stack.Count > 0)
        {
            int currentClothes = stack.Peek();

            if (sum + currentClothes <= rackCapacity)
            {
                sum += stack.Pop();
            }
            else
            {
                racks++;
                sum = 0;
            }
        }

        Console.WriteLine(racks);   
    }
}