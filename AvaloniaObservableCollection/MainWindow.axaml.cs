using Avalonia.Controls;

namespace AvaloniaObservableCollection
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new ViewModel();
            InitializeComponent();
        }
    }
}
