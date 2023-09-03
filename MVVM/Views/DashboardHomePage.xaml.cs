using OnaxDallE.MVVM.ViewModels;

namespace OnaxDallE.MVVM.Views;

public partial class DashboardHomePage : ContentPage
{
	public DashboardHomePage(DashboardHomeViewModel dhVm)
	{
		InitializeComponent();
		BindingContext = dhVm;
	}
}