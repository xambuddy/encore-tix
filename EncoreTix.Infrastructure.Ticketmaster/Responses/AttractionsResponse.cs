using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;
using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Responses;

public class AttractionsResponse
{
    [JsonProperty("_embedded")]
    public Embedded Embedded { get; set; }
}

public class Embedded
{
    [JsonProperty("attractions")]
    public List<AttractionDto> Attractions { get; set; }
}
