namespace EncoreTix.Core.Models;

public class Venue
{
    public string Href { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public string Id { get; set; }

    public bool Test { get; set; }

    public string Locale { get; set; }

    public string PostalCode { get; set; }

    public string Timezone { get; set; }

    public City City { get; set; }

    public State State { get; set; }
}

public class City
{
    public string Name { get; set; }
}

public class State
{
    public string Name { get; set; }

    public string StateCode { get; set; }
}
