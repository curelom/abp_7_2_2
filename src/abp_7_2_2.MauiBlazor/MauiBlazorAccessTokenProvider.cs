using abp_7_2_2.MauiBlazor.Settings;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.IdentityModel.MauiBlazor;

namespace abp_7_2_2.MauiBlazor;

[ExposeServices(typeof(IAbpMauiAccessTokenProvider))]
public class MauiBlazorAccessTokenProvider : IAbpMauiAccessTokenProvider , ITransientDependency
{
    private readonly Iabp_7_2_2ApplicationSettingService _abp_7_2_2ApplicationSettingService;

    public MauiBlazorAccessTokenProvider(Iabp_7_2_2ApplicationSettingService abp_7_2_2ApplicationSettingService)
    {
        _abp_7_2_2ApplicationSettingService = abp_7_2_2ApplicationSettingService;
    }

    public async Task<string> GetAccessTokenAsync()
    {
        return await _abp_7_2_2ApplicationSettingService.GetAccessTokenAsync();
    }
}
