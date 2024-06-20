namespace RealEstate;

public class Ad
{
    private int _id { get; set; }
    private string _address { get; set; }
    private Agent _agent { get; set; }
    public District District { get; set; }
    public double Price { get; set; }
    public bool Furnished { get; set; }

    public Ad(int id, string address, Agent agent, District district, int price, bool furnished)
    {
        _id = id;
        _address = address;
        _agent = agent;
        District = district;
        Price = price;
        Furnished = furnished;
    }

    public override string ToString()
    {
        string furnishedText = Furnished ? "furnished" : "not furnished";
        return $"{_id}: {_address} in District {District} is {furnishedText}, being sold by {_agent.Name} for £{Price}";
    }
}