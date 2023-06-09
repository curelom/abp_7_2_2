using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abp_7_2_2;

[Dependency(ReplaceServices = true)]
public class abp_7_2_2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "abp_7_2_2";
}
