namespace RealEstate;

public class Agency
{
    private List<User> _users { get; set; }
    private List<Ad> _ads { get; set; }

    public Agency()
    {
        _users = new List<User>();
        _ads = new List<Ad>();
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void AddAd(Ad ad)
    {
        _ads.Add(ad);
    }

    public List<User> GetUsers()
    {
        return _users;
    }
}