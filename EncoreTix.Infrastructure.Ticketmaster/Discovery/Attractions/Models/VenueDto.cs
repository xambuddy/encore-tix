using Newtonsoft.Json;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

public class VenueDto
{
    [JsonProperty("href")]
    public string Href { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("test")]
    public bool Test { get; set; }

    [JsonProperty("locale")]
    public string Locale { get; set; }

    [JsonProperty("postalCode")]
    public string PostalCode { get; set; }

    [JsonProperty("timezone")]
    public string Timezone { get; set; }

    [JsonProperty("city")]
    public CityDto City { get; set; }

    [JsonProperty("state")]
    public StateDto State { get; set; }
}

public class CityDto
{
    [JsonProperty("name")]
    public string Name { get; set; }
}

public class StateDto
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("stateCode")]
    public string StateCode { get; set; }
}