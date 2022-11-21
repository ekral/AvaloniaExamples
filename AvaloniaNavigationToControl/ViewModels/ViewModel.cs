using AvaloniaNavigationToControl.Services;

namespace AvaloniaNavigationToControl.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        private readonly NavigationService navigation;

        public string Name => nameof(ViewModel);

        public ViewModel(NavigationService navigation)
        {
            this.navigation = navigation;
        }

        public void Navigate()
        {
            navigation.Navigate(new Views.SecondUserControl(this));
        }
    }
}
