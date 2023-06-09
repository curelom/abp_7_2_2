using abp_7_2_2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abp_7_2_2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class abp_7_2_2Controller : AbpControllerBase
{
    protected abp_7_2_2Controller()
    {
        LocalizationResource = typeof(abp_7_2_2Resource);
    }
}
