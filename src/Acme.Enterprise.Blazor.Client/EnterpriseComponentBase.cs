using Acme.Enterprise.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.Enterprise.Blazor.Client;

public abstract class EnterpriseComponentBase : AbpComponentBase
{
    protected EnterpriseComponentBase()
    {
        LocalizationResource = typeof(EnterpriseResource);
    }
}
