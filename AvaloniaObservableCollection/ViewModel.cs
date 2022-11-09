using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaObservableCollection
{
    public class Student
    {
        public required int Rocnik { get; set; }
        public required string Jmeno { get; set; }
    }

    public class ViewModel
    {
        private readonly string[] jmena = { "Karel", "Jiri", "Alena", "Bohdan" };

        public ObservableCollection<Student> Studenti { get; } = new();

        public void Pridej()
        {
            int rocnik = Random.Shared.Next(1, 4);
            string jmeno = jmena[Random.Shared.Next(0, jmena.Length - 1)];

            Studenti.Add(new Student() { Rocnik = rocnik, Jmeno = jmeno });
        }
    }
}
