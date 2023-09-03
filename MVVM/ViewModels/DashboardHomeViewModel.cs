using OnaxDallE.MVVM.Models;
using OnaxDallE.MVVM.Models.Common;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace OnaxDallE.MVVM.ViewModels
{
    public class DashboardHomeViewModel : CommonINotify
    {
        
        public ObservableCollection<UserProfile> Profiles
        {
            get => _profiles ?? DashboardHomeViewModel.GetDefaultUserProfile();
            set
            {
                _profiles = value;
                OnPropertyChanged(nameof(Profiles));
            }
        }

        public ObservableCollection<GeneratedImage> GeneratedImages
        {
            get => _generatedImages ?? DashboardHomeViewModel.LoadGeneratedImagesData();
            set
            {
                _generatedImages = value;
                OnPropertyChanged(nameof(GeneratedImages));
            }
        }

        public ICommand CmdMenuClicked => new Command(MenuClicked);

        #region PRIVATE
        private ObservableCollection<UserProfile> _profiles;
        private ObservableCollection<GeneratedImage> _generatedImages;

        private void MenuClicked(object obj)
        {
            App.Current.MainPage.DisplayAlert("User Action", "Navigate to menu", "Ok");
        }

        public void ITappedCmd(object sender, TappedEventArgs e)
        {
            ((VisualElement)sender).BackgroundColor = Color.FromRgb(222,233,120);
        }

        private static ObservableCollection<UserProfile> GetDefaultUserProfile()
        {
            return new ObservableCollection<UserProfile> {
                new UserProfile{UserName= "Hector", NumbOfPhotos=12, ProfileImage = "profile1.jpeg"},
                new UserProfile{UserName= "Maddy", NumbOfPhotos=5, ProfileImage = "profile2.jpeg"},
                new UserProfile{UserName= "flyboy", NumbOfPhotos=5, ProfileImage = "profile3.jpeg"},
                new UserProfile{UserName= "flyboy", NumbOfPhotos=5, ProfileImage = "profile4.jpeg"},
                new UserProfile{UserName= "flyboy", NumbOfPhotos=5, ProfileImage = "profile5.jpeg"},
                new UserProfile{UserName= "flyboy", NumbOfPhotos=5, ProfileImage = "profile6.jpeg"},
                new UserProfile{UserName= "flyboy", NumbOfPhotos=5, ProfileImage = "profile7.jpeg"}
            };
        }

        private static ObservableCollection<GeneratedImage> LoadGeneratedImagesData()
        {
            return new ObservableCollection<GeneratedImage> {
                new GeneratedImage{ImagePath="generated0.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
                new GeneratedImage{ImagePath="generated1.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
                new GeneratedImage{ImagePath="generated2.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
                new GeneratedImage{ImagePath="generated3.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
                new GeneratedImage{ImagePath="generated4.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
                new GeneratedImage{ImagePath="generated5.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
                new GeneratedImage{ImagePath="generated6.jpeg",MainKeyWord="Finest", Keywords = new List<string>{"word1","word2","word3"}  },
            };
        }
        #endregion
    }
}
