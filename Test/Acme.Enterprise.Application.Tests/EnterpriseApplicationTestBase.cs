using Volo.Abp.Modularity;

namespace Acme.Enterprise;

public abstract class EnterpriseApplicationTestBase<TStartupModule> : EnterpriseTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
