using Xunit;

namespace Acme.Enterprise.EntityFrameworkCore;

[CollectionDefinition(EnterpriseTestConsts.CollectionDefinitionName)]
public class EnterpriseEntityFrameworkCoreCollection : ICollectionFixture<EnterpriseEntityFrameworkCoreFixture>
{

}
