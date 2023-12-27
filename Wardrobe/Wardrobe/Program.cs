internal class Program
{
    private static void Main(string[] args)
    {
        //Color, Type, Count
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            // Blue -> dress,jeans,hat
            string[] inputArgs = Console.ReadLine().Split(" -> ");
            string color = inputArgs[0];
            string[] clothes = inputArgs[1].Split(',');

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }

            foreach (var item in clothes)
            {
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color].Add(item, 0);
                }

                wardrobe[color][item]++;
            }
        }


        //White tanktop
        string[] targetClothes = Console.ReadLine().Split();

        //Dictionary<string, Dictionary<string, int>>

        foreach (var color in wardrobe)
        {
            Console.WriteLine($"{color.Key} clothes:");

            foreach (var (clothe, value) in color.Value)
            {
                if (clothe == targetClothes[1] && color.Key == targetClothes[0])
                {
                    Console.WriteLine($"* {clothe} - {value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {clothe} - {value}");
                }
            }
        }



    }
}