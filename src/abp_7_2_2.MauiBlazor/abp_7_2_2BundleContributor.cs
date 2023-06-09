﻿using Volo.Abp.Bundling;

namespace abp_7_2_2.MauiBlazor;

/* Add your global styles/scripts here.
 * See https://docs.abp.io/en/abp/latest/UI/Blazor/Global-Scripts-Styles to learn how to use it
 */
public class abp_7_2_2BundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {
    }

    public void AddStyles(BundleContext context)
    {
        context.Add("css/app.css", true);
    }
}
