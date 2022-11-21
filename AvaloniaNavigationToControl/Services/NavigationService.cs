using Avalonia.Controls;

namespace AvaloniaNavigationToControl.Services
{
    public class NavigationService
    {
        private readonly ContentControl transitioningContentControl;

        public NavigationService(ContentControl contentControl)
        {
            this.transitioningContentControl = contentControl;
        }

        public void Navigate(ContentControl view)
        {
            transitioningContentControl.Content = view;
        }
    }
}
