using System.Threading.Tasks;

namespace CQRS.ScalableApp.Data;

public interface IScalableAppDbSchemaMigrator
{
    Task MigrateAsync();
}
