using Avalonia.Controls;

namespace AvaloniaNavigationToControl.Views
{
    public partial class SecondUserControl : UserControl
    {
        public SecondUserControl()
        {
            InitializeComponent();
        }

        public SecondUserControl(ViewModels.ViewModel viewModel) : this()
        {
            DataContext = viewModel;
        }
    }
}
