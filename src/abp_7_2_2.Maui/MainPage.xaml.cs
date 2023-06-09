using abp_7_2_2.Maui.ViewModels;
using Volo.Abp.DependencyInjection;

namespace abp_7_2_2.Maui;

public partial class MainPage : ContentPage, ITransientDependency
{
    public MainPage(
		MainPageViewModel vm)
	{
        BindingContext = vm;
        InitializeComponent();
    }
}