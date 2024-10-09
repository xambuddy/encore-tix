using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;
using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Responses.Events;

public class EventsResponse
{
    [JsonProperty("_embedded")]
    public EmbeddedDto Embedded { get; set; }
}