internal class Program
{
    private static void Main(string[] args)
    {
        //Dictionary structure  ------>
        //Saffrona -> following.Add(....)
        //Saffrona -> followers.Add(....)
        var vlogger = new Dictionary<string, Dictionary<string, HashSet<string>>>();

        /* LOGIC ----->
         if(!vlogger.ContainsKey("Saffrona"))
         {
             vlogger.Add("Saffrona", new Dictionary<string, HashSet<string>>());
         }

         vlogger["Saffrona"].Add("following",new HashSet<string>());
         vlogger["Saffrona"].Add("followers", new HashSet<string>());

         vlogger["Saffrona"]["following"].Add("Emil");*/

        string input = Console.ReadLine();

        string following = "following";
        string followers = "followers";

        while (input != "Statistics")
        {
            //Input --->
            //EmilConrad joined The V-Logger
            //VenomTheDoctor followed The V-Logger

            string[] inputArgs = input.Split();

            string action = inputArgs[1];
            string user = inputArgs[0];
            string starUser = inputArgs[2];

            if (action == "joined" && !vlogger.ContainsKey(user))
            {
                vlogger.Add(user, new Dictionary<string, HashSet<string>>());
                vlogger[user].Add(following, new HashSet<string>());
                vlogger[user].Add(followers, new HashSet<string>());
            }
            else if (action == "followed" && vlogger.ContainsKey(user)
                && vlogger.ContainsKey(starUser) && user != starUser)
            {
                vlogger[user][following].Add(starUser);
                vlogger[starUser][followers].Add(user);
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"The V-Logger has a total of {vlogger.Count} vloggers in its logs.");

        var sortedVloggers = vlogger.OrderByDescending(x => x.Value[followers].Count())
            .ThenBy(x => x.Value[following].Count());

        int counter = 1;

        foreach (var currentVlogger in sortedVloggers)
        {
            Console.WriteLine($"{counter}. {currentVlogger.Key} : {currentVlogger.Value[followers].Count} followers, " +
                $"{currentVlogger.Value[following].Count} following");

            if (counter == 1)
            {
                foreach (var item in currentVlogger.Value[followers].OrderBy(x => x))
                {
                    Console.WriteLine($"*  {item}");
                }
            }

            counter++;
        }


    }
}