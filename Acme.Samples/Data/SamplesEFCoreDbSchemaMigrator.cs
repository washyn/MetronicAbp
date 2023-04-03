using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace Acme.Samples.Data;

public class SamplesEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public SamplesEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SamplesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SamplesDbContext>()
            .Database
            .MigrateAsync();
    }
}
