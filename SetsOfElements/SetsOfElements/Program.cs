internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        HashSet<int> leftSet = new HashSet<int>();
        HashSet<int> rightSet = new HashSet<int>();


        //3,5,7
        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            leftSet.Add(currentNum);
        }

        //2,3,5
        for (int i = 0; i < m; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            rightSet.Add(currentNum);
        }

        List<int> numbers =  leftSet.Intersect(rightSet).ToList();

        Console.WriteLine(string.Join(" ",numbers));
    }
}