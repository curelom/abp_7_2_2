using IdentityModel.OidcClient;

namespace abp_7_2_2.Maui.Oidc;

public interface ILoginService
{
    Task<LoginResult> LoginAsync();

    Task<LogoutResult> LogoutAsync();

    Task<string> GetAccessTokenAsync();
}