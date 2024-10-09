using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

public class EmbeddedDto
{
    [JsonProperty("events")]
    public List<EventDto> Events { get; set; }

    [JsonProperty("venues")]
    public List<VenueDto> Venues { get; set; }

    [JsonProperty("attractions")]
    public List<AttractionDto> Attractions { get; set; }
}
