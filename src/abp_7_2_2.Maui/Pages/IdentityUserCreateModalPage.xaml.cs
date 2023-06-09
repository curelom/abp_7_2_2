using CommunityToolkit.Mvvm.Messaging;
using abp_7_2_2.Maui.Messages;
using abp_7_2_2.Maui.ViewModels;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace abp_7_2_2.Maui.Pages;

public partial class IdentityUserCreateModalPage : ContentPage, ITransientDependency
{
    public IdentityUserCreateModalPage(IdentityUserCreateViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}