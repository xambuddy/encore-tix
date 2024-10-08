using EncoreTix.Infrastructure.Ticketmaster.Configurations;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;
using EncoreTix.Infrastructure.Ticketmaster.Responses;
using Newtonsoft.Json;
using System.Web;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Services;

public class AttractionsService(HttpClient httpClient, TicketmasterConfig ticketmasterConfig) : IAttractionsService
{
    public async Task<IEnumerable<AttractionDto>> SearchAttractions(string? keyword = null, int size = 20, int page = 0)
    {
        var uriBuilder = new UriBuilder(httpClient.BaseAddress);

        var query = HttpUtility.ParseQueryString(uriBuilder.Query);

        query["apikey"] = ticketmasterConfig.Apikey;
        query["size"] = size.ToString();
        query["page"] = page.ToString();

        if (!string.IsNullOrEmpty(keyword))
        {
            query["keyword"] = keyword;
        }

        uriBuilder.Query = query.ToString();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = uriBuilder.Uri
        };

        using var response = await httpClient.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var attractionsReponse = JsonConvert.DeserializeObject<AttractionsResponse>(content);

        return attractionsReponse?.Embedded?.Attractions ?? new List<AttractionDto>();
    }
}
