using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

public class ExternalLinksDto
{
    [JsonProperty("youtube")]
    public IEnumerable<ExternalLinkDto> Youtube { get; set; }

    [JsonProperty("twitter")]
    public IEnumerable<ExternalLinkDto> Twitter { get; set; }

    [JsonProperty("facebook")]
    public IEnumerable<ExternalLinkDto> Facebook { get; set; }

    [JsonProperty("instagram")]
    public IEnumerable<ExternalLinkDto> Instagram { get; set; }

    [JsonProperty("homepage")]
    public IEnumerable<ExternalLinkDto> Homepage { get; set; }
}

public class ExternalLinkDto
{
    [JsonProperty("url")]
    public string Url { get; set; }
}