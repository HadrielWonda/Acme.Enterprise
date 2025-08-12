using System;
using System.Collections.Generic;
using System.Text;
using Acme.Enterprise.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Enterprise;

/* Inherit your application services from this class.
 */
public abstract class EnterpriseAppService : ApplicationService
{
    protected EnterpriseAppService()
    {
        LocalizationResource = typeof(EnterpriseResource);
    }
}
