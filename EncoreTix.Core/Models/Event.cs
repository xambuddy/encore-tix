namespace EncoreTix.Core.Models;

public class Event
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public bool Test { get; set; }

    public string Url { get; set; }

    public string Locale { get; set; }

    public List<Image> Images { get; set; }

    public Dates Dates { get; set; }

    public IEnumerable<Venue> Venues { get; set; }
}

public class Dates
{
    public StartDate Start { get; set; }

    public string Timezone { get; set; }

    public DateStatus Status { get; set; }
}

public class StartDate
{
    public string LocalDate { get; set; }

    public bool DateTBD { get; set; }

    public bool DateTBA { get; set; }

    public bool TimeTBA { get; set; }

    public bool NoSpecificTime { get; set; }
}

public class DateStatus
{
    public string Code { get; set; }
}
