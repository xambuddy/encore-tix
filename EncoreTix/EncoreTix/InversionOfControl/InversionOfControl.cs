using EncoreTix.Application.Features.Attractions.Queries;
using EncoreTix.Application.Profiles;

namespace EncoreTix.InversionOfControl;

public static class InversionOfControl
{
    public static void RegisterMediatrServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<GetAttractionsQuery>());
    }

    public static void RegisterAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AttractionProfile));
    }
}
