using EncoreTix.Application.InversionOfControl;
using EncoreTix.Behaviors;
using EncoreTix.Components;
using EncoreTix.Infrastructure.Ticketmaster.InversionOfControl;
using EncoreTix.InversionOfControl;
using MediatR;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add MudBlazor services
builder.Services.AddMudServices();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.RegisterMediatrServices();
builder.Services.RegisterAutoMapper();
builder.Services.RegisterTicketmasterServices(builder.Configuration);
builder.Services.RegisterFeatureServices();

builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
