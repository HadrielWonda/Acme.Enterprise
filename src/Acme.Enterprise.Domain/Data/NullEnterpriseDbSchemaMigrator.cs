using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Enterprise.Data;

/* This is used if database provider does't define
 * IEnterpriseDbSchemaMigrator implementation.
 */
public class NullEnterpriseDbSchemaMigrator : IEnterpriseDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
