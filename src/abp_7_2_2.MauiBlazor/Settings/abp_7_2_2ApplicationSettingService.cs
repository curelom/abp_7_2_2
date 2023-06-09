﻿using Volo.Abp.DependencyInjection;

namespace abp_7_2_2.MauiBlazor.Settings;

public class abp_7_2_2ApplicationSettingService : Iabp_7_2_2ApplicationSettingService, ITransientDependency
{
    private const string AccessTokenKey = "access_token";

    public Task<string> GetAccessTokenAsync()
    {
        return Task.FromResult(Preferences.Get(AccessTokenKey, string.Empty));
    }

    public Task SetAccessTokenAsync(string? accessToken)
    {
        if (accessToken.IsNullOrWhiteSpace())
        {
            Preferences.Remove(AccessTokenKey);
        }
        else
        {
            Preferences.Set(AccessTokenKey, accessToken);
        }

        return Task.CompletedTask;
    }
}
