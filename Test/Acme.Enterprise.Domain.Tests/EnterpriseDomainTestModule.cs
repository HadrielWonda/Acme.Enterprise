using Volo.Abp.Modularity;

namespace Acme.Enterprise;

[DependsOn(
    typeof(EnterpriseDomainModule),
    typeof(EnterpriseTestBaseModule)
)]
public class EnterpriseDomainTestModule : AbpModule
{

}
