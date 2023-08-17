using System.ComponentModel;

namespace OnaxDallE.MVVM.Models.Common
{
    public abstract class CommonINotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string sender) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(sender));
    }
}
