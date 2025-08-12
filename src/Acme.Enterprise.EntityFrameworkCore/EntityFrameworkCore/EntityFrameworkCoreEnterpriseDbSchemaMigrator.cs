using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.Enterprise.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Enterprise.EntityFrameworkCore;

public class EntityFrameworkCoreEnterpriseDbSchemaMigrator
    : IEnterpriseDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEnterpriseDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the EnterpriseDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<EnterpriseDbContext>()
            .Database
            .MigrateAsync();
    }
}
