namespace RealEstate;

public class Agent : User
{
    private List<Ad> Ads { get; set; }

    public Agent(string name, string contact) : base(name, contact)
    {
        Ads = new List<Ad>();
    }

    public void AddAd(Ad ad)
    {
        Ads.Add(ad);
    }

    public void PostAllAds()
    {
        foreach (var ad in Ads)
        {
            PostAd(ad);
        }
    }

    private void PostAd(Ad ad)
    {
        Console.WriteLine(ad.ToString());
    }

}