using Avalonia.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaApplicationForms
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Students { get; } = new()
        {
            "Pavla", "Alena", "Denis"
        };

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            string selected = Students.FirstOrDefault() ?? "";
            listBoxStudents.SelectedItem = selected;

        }

        private void ListBoxStudents_SelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count > 0 && e.AddedItems[0] is string selected)
            {
                textBlockSelectedStudent.Text = $"Selected: {selected}";
            }
        }

        private void Tlacitko_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            string student = textBoxJmeno.Text;

            if (string.IsNullOrEmpty(student)) return;

            Students.Add(student);

            listBoxStudents.SelectedItem = student;
            textBoxJmeno.Text = "";
        }
    }
}
