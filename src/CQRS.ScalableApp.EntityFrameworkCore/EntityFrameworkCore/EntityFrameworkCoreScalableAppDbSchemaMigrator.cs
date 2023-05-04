using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CQRS.ScalableApp.Data;
using Volo.Abp.DependencyInjection;

namespace CQRS.ScalableApp.EntityFrameworkCore;

public class EntityFrameworkCoreScalableAppDbSchemaMigrator
    : IScalableAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreScalableAppDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ScalableAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ScalableAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
