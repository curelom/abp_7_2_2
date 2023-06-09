using Android.App;
using Android.Content;
using Android.Content.PM;

namespace abp_7_2_2.MauiBlazor.Platforms.Android;

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop)]
[IntentFilter(new[] { Intent.ActionView },
    Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
    DataScheme = CALLBACK_SCHEME)]
public class abp_7_2_2WebAuthenticatorCallbackActivity : WebAuthenticatorCallbackActivity
{
   public const string CALLBACK_SCHEME = "abp_7_2_2mauiblazor";
}
