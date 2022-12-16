using Microsoft.Extensions.DependencyInjection;

namespace VisNetwork.Blazor;

public static class VisNetworkConfiguration
{
    /// <summary>
    /// Add Singleton <see cref="IJSModule"/> to the <see cref="ServiceCollection"/>
    /// Use this version for WASM projects
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddVisNetwork(this IServiceCollection services)
    {
        services.AddSingleton<IVersionProvider, VersionProvider>();
        services.AddSingleton<IJSModule, JSModule>();
        return services;
    }    

    /// <summary>
    /// Add scoped <see cref="IJSModule"/> to the <see cref="ServiceCollection"/> 
    /// Use this version for Server side projects
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddVisNetworkScoped(this IServiceCollection services)
    {
        services.AddScoped<IVersionProvider, VersionProvider>();
        services.AddScoped<IJSModule, JSModule>();
        return services;
    }
}
