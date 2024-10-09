using EncoreTix.Application.Features.Attractions.Services;
using EncoreTix.Application.Features.Events.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EncoreTix.Application.InversionOfControl;

public static class InversionOfControl
{
    public static void RegisterFeatureServices(this IServiceCollection services)
    {
        services.AddScoped<IAttractionsService, AttractionsService>()
            .AddScoped<IEventsService, EventsService>();
    }
}
