namespace EncoreTix.API.InversionOfControl;

public static class InversionOfControl
{
    public static void RegisterMediatrServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Program>());
    }
}
