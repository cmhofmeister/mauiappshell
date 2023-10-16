using CommunityToolkit.Mvvm.ComponentModel;

namespace AppShell
{
    public partial class AppShellViewModel : ObservableObject
    {

        public AppShellViewModel()
        {
            HomeText = "Home";
            IsVisible = true;
        }

        [ObservableProperty]
        bool isVisible;

        [ObservableProperty]
        string homeText;
    }
}
