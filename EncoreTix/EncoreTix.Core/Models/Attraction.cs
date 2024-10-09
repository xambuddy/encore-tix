namespace EncoreTix.Core.Models;

public class Attraction
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    public bool Test { get; set; }

    public string Locale { get; set; }

    public List<Image> Images { get; set; }

    public ExternalLinks ExternalLinks { get; set; }
}
