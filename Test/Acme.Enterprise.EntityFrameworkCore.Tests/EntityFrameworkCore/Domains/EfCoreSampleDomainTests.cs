using Acme.Enterprise.Samples;
using Xunit;

namespace Acme.Enterprise.EntityFrameworkCore.Domains;

[Collection(EnterpriseTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EnterpriseEntityFrameworkCoreTestModule>
{

}
