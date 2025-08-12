using Volo.Abp.Modularity;

namespace Acme.Enterprise;

/* Inherit from this class for your domain layer tests. */
public abstract class EnterpriseDomainTestBase<TStartupModule> : EnterpriseTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
