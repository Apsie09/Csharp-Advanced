internal class Program
{
    private static void Main(string[] args)
    {
        var cities = new Dictionary<string, Dictionary<string, List<string>>>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine();
            var parts = line.Split(' ');
            var contintent = parts[0];
            var country = parts[1];
            var city = parts[2];

            if (!cities.ContainsKey(contintent))
            {
                cities.Add(contintent, new Dictionary<string, List<string>>());
            }

            if (!cities[contintent].ContainsKey(country))
            {
                cities[contintent][country] = new List<string>();
            }

            cities[contintent][country].Add(city);
        }

        foreach (var continent in cities)
        {
            Console.WriteLine($"{continent.Key}:");

            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
            }
        }

    }
}