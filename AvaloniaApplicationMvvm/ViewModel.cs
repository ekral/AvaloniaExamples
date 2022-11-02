using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplicationMvvm
{
    public class ViewModel : ViewModelBase
    {
        private string selected = "";
        public string SelectedStudent
        { 
            get => selected; 
            set => SetProperty(ref selected, value); 
        }

        public string StudentName { get; set; } = "";

        public ObservableCollection<string> Students { get; } = new()
        {
            "Pavla", "Alena", "Denis"
        };

        public ViewModel()
        {
            SelectedStudent = Students.FirstOrDefault() ?? "";
        }

        public void Add()
        {
            if (string.IsNullOrEmpty(StudentName)) return;

            Students.Add(StudentName); 
            SelectedStudent = StudentName;
            StudentName = "";
        }
    }
}
