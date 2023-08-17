using OnaxDallE.MVVM.ViewModels;

namespace OnaxDallE.MVVM.Views;

public partial class UserProfilePage : ContentPage
{
    public UserProfilePage(UserProfileViewModel upVm)
	{
		InitializeComponent();
		BindingContext = upVm;
	}
}