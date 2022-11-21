using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaNavigationToControl.Services;
using AvaloniaNavigationToControl.ViewModels;
using AvaloniaNavigationToControl.Views;

namespace AvaloniaNavigationToControl
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                MainWindow mainWindow = new();
                NavigationService navigationService = new(mainWindow.transitioningContentControl);
                ViewModel viewModel = new(navigationService);
                FirstUserControl firstUserControl = new(viewModel);
                desktop.MainWindow = mainWindow;

                navigationService.Navigate(firstUserControl);
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
