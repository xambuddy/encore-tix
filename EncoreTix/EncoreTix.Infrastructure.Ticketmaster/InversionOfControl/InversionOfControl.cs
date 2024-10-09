using EncoreTix.Infrastructure.Ticketmaster.Configurations;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Clients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EncoreTix.Infrastructure.Ticketmaster.InversionOfControl;

public static class InversionOfControl
{
    public static void RegisterTicketmasterServices(this IServiceCollection services, IConfiguration configuration)
    {
        var ticketmasterConfig = configuration.GetSection(nameof(TicketmasterConfig)).Get<TicketmasterConfig>();

        services
            .AddScoped<TicketmasterConfig>(x => ticketmasterConfig)
            .AddHttpClient<IAttractionsClient, AttractionsClient>(client =>
            {
                client.BaseAddress = new Uri(new Uri(ticketmasterConfig.BaseUrl), "discovery/v2/attractions");
            });
        services
            .AddHttpClient<IEventsClient, EventsClient>(client =>
            {
                client.BaseAddress = new Uri(new Uri(ticketmasterConfig.BaseUrl), "discovery/v2/events");
            });
    }
}
