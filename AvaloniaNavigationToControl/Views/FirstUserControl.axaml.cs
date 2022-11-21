using Avalonia.Controls;

namespace AvaloniaNavigationToControl.Views
{
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
        }

        public FirstUserControl(ViewModels.ViewModel viewModel) : this()
        {
            DataContext = viewModel;
        }
    }
}
