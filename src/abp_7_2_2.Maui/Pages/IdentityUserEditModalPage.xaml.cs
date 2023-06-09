using abp_7_2_2.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace abp_7_2_2.Maui.Pages;

public partial class IdentityUserEditModalPage : ContentPage, ITransientDependency
{
	public IdentityUserEditModalPage(IdentityUserEditViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}