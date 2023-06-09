namespace abp_7_2_2.MauiBlazor.Settings;

public interface Iabp_7_2_2ApplicationSettingService
{   
   Task<string> GetAccessTokenAsync();
    
    Task SetAccessTokenAsync(string? accessToken);
}