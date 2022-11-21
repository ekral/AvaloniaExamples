using Avalonia.Controls;

namespace AvaloniaNavigationToControl.Services
{
    public class NavigationService
    {
        private readonly ContentControl transitioningContentControl;

        public NavigationService(ContentControl transitioningContentControl)
        {
            this.transitioningContentControl = transitioningContentControl;
        }

        public void Navigate(ContentControl view)
        {
            transitioningContentControl.Content = view;
        }
    }
}
