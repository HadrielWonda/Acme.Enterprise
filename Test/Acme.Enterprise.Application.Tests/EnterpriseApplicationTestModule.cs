using Volo.Abp.Modularity;

namespace Acme.Enterprise;

[DependsOn(
    typeof(EnterpriseApplicationModule),
    typeof(EnterpriseDomainTestModule)
)]
public class EnterpriseApplicationTestModule : AbpModule
{

}
