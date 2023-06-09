using abp_7_2_2.Maui.Pages;
using abp_7_2_2.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace abp_7_2_2.Maui;

public partial class AppShell : Shell, ITransientDependency
{
    public AppShell(ShellViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();

        Routing.RegisterRoute(nameof(IdentityUserCreateModalPage), typeof(IdentityUserCreateModalPage));
        Routing.RegisterRoute(nameof(IdentityUserEditModalPage), typeof(IdentityUserEditModalPage));
    }
}
