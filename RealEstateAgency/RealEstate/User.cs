namespace RealEstate;

public abstract class User
{
    public string Name { get; set; }
    public string Contact { get; set; }

    public User(string name, string contact)
    {
        Name = name;
        Contact = contact;
    }
}