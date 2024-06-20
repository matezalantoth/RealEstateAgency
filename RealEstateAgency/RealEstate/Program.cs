// See https://aka.ms/new-console-template for more information

namespace RealEstate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var agency = new Agency();
            var agent = new Agent("mate", "123");
            var ad = new Ad(1, "1 Road Street", agent, District.V, 1200, true);
            agent.AddAd(ad);
            agency.AddUser(agent);
            foreach (var user in agency.GetUsers())
            {
                (user as Agent)?.PostAllAds();
            }
        }
    }
}

