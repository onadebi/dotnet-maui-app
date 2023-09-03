using OnaxDallE.MVVM.ViewModels;
using OnaxDallE.MVVM.Views;

namespace OnaxDallE;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new DashboardHomePage( new DashboardHomeViewModel());
        //MainPage = new UserProfilePage(new UserProfileViewModel());// new AppShell();
    }
}
