using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CQRS.ScalableApp.Data;

/* This is used if database provider does't define
 * IScalableAppDbSchemaMigrator implementation.
 */
public class NullScalableAppDbSchemaMigrator : IScalableAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
