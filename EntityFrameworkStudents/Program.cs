// https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
using Microsoft.EntityFrameworkCore;
using System.IO;

using UniversityContext db = new();
db.Students.Add(new Student() { Jmeno = "ahoj", Rocnik = 3 });

foreach (Student student in db.Students)
{
    Console.WriteLine($"Id: {student.Id, 3} Jmeno: {student.Jmeno, 12} Rocnik: {student.Rocnik, 3}");
}

Console.WriteLine("konec");

class UniversityContext : DbContext
{
    public DbSet<Student> Students { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string path = Path.Join(folder, "database.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student() { Id = 1, Rocnik = 2, Jmeno = "Bohdan" },
            new Student() { Id = 2, Rocnik = 2, Jmeno = "Hubert" },
            new Student() { Id = 3, Rocnik = 1, Jmeno = "Alena" });
    }
}

class Student
{
    public int Id { get; set; }
    public int Rocnik { get; set; }
    public string Jmeno { get; set; }
}
