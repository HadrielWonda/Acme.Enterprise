using Acme.Enterprise.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Enterprise.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EnterpriseController : AbpControllerBase
{
    protected EnterpriseController()
    {
        LocalizationResource = typeof(EnterpriseResource);
    }
}
