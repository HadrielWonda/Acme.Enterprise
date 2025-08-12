using System.Threading.Tasks;

namespace Acme.Enterprise.Data;

public interface IEnterpriseDbSchemaMigrator
{
    Task MigrateAsync();
}
