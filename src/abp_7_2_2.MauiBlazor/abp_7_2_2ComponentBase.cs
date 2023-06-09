using abp_7_2_2.Localization;
using Volo.Abp.AspNetCore.Components;

namespace abp_7_2_2.MauiBlazor;

public abstract class abp_7_2_2ComponentBase : AbpComponentBase
{
    protected abp_7_2_2ComponentBase()
    {
        LocalizationResource = typeof(abp_7_2_2Resource);
    }
}