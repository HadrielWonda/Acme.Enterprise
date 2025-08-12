using Acme.Enterprise.Samples;
using Xunit;

namespace Acme.Enterprise.EntityFrameworkCore.Applications;

[Collection(EnterpriseTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EnterpriseEntityFrameworkCoreTestModule>
{

}
