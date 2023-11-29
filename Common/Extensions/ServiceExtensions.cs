#region

using Microsoft.Extensions.DependencyInjection;
using Moka.Beer.Common.Services;

#endregion

namespace Moka.Beer.Common.Extensions;

public static class ServiceExtensions
{
    public static void AddMokaCss(this IServiceCollection services)
    {
        services.AddScoped<ThemeService>();
    }
}