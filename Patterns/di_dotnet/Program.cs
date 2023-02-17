global using Microsoft.Extensions.DependencyInjection;

using ServiceProvider container = GetServiceProvider();



static ServiceProvider GetServiceProvider()
{
    ServiceCollection services = new();
    // add singleton
    // add transient
    return services.BuildServiceProvider();
}