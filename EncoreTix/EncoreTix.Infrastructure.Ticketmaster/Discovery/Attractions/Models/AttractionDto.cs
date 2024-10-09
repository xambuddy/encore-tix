using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

public class AttractionDto
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("test")]
    public bool Test { get; set; }

    [JsonProperty("locale")]
    public string Locale { get; set; }

    [JsonProperty("images")]
    public IList<ImageDto> Images { get; set; }

    [JsonProperty("externalLinks")]
    public ExternalLinksDto ExternalLinks { get; set; }
}
