using OnaxDallE.MVVM.Models;
using System.Windows.Input;

namespace OnaxDallE.MVVM.ViewModels;

public class UserProfileViewModel
{
    public UserProfile UserProfDetail { get; set; }
    
    public UserProfileViewModel()
    {
        UserProfDetail = new()
        {
            NumbOfPhotos = 3,
            ProfileImage = "profile.png",
            UserName = "onax"
        };
    }

    public ICommand ChangeUserProf => new Command(ChangeUser);
    private void ChangeUser(object obj)
    {
        if (UserProfDetail != null)
        {
            UserProfDetail.UserName = "Onadebi";
        }
    } 

}
