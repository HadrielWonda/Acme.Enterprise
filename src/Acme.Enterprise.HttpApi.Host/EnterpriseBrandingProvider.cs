using Microsoft.Extensions.Localization;
using Acme.Enterprise.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.Enterprise;

[Dependency(ReplaceServices = true)]
public class EnterpriseBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<EnterpriseResource> _localizer;

    public EnterpriseBrandingProvider(IStringLocalizer<EnterpriseResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
