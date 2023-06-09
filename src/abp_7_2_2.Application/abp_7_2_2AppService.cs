using abp_7_2_2.Localization;
using Volo.Abp.Application.Services;

namespace abp_7_2_2;

/* Inherit your application services from this class.
 */
public abstract class abp_7_2_2AppService : ApplicationService
{
    protected abp_7_2_2AppService()
    {
        LocalizationResource = typeof(abp_7_2_2Resource);
    }
}
