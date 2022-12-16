using Bunit;
using Microsoft.Extensions.DependencyInjection;

namespace VisNetwork.Blazor.Tests;

public class VisNetworkConfig
{
    public static void AddVisNetwork(TestServiceProvider services)
    {
        services.AddSingleton<IVersionProvider, VersionProvider>();
        services.AddSingleton<IJSModule, JSModule>();
    }

    public static void AddVisNetworkScoped(TestServiceProvider services)
    {
        services.AddScoped<IVersionProvider, VersionProvider>();
        services.AddScoped<IJSModule, JSModule>();
    }

    internal class VersionProvider : IVersionProvider
    {
        public string Version => string.Empty;
    }
}
