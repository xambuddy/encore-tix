using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;
using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Responses.Attractions;

public class AttractionsResponse
{
    [JsonProperty("_embedded")]
    public EmbeddedDto Embedded { get; set; }
}