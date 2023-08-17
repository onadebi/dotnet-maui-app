using OnaxDallE.MVVM.Models.Common;

namespace OnaxDallE.MVVM.Models;

public class UserProfile : CommonINotify
{
    string _userName;
    string _profileImage;
    uint _numbOfPhotos;

    public string UserName { get => _userName; set { _userName = value; OnPropertyChanged(nameof(UserName)); } }
    public string ProfileImage { get => _profileImage; set { _profileImage = value; OnPropertyChanged(nameof(ProfileImage)); } }
    public uint NumbOfPhotos { get => _numbOfPhotos; set { _numbOfPhotos = value; OnPropertyChanged(nameof(NumbOfPhotos)); } }
}
