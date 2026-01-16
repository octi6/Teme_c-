using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Nume { get; set; }
    public int Nota { get; set; }
}

class Program
{
    static List<Student> studenti = new();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1.Adauga  2.Afiseaza  3.Update  4.Sterge  5.Promovati  0.Exit");
            Console.Write("Alege: ");
            string opt = Console.ReadLine();

            try
            {
                switch (opt)
                {
                    case "1": AddStudent(); break;
                    case "2": ShowAll(); break;
                    case "3": UpdateStudent(); break;
                    case "4": DeleteStudent(); break;
                    case "5": ShowPromovati(); break;
                    case "0": return;
                    default: Console.WriteLine("Optiune invalida"); break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}");
            }
        }
    }

    // CREATE
    static void AddStudent()
    {
        Console.Write("Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Nume: ");
        string nume = Console.ReadLine();

        Console.Write("Nota: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 1 || nota > 10)
            throw new Exception("Nota trebuie intre 1 si 10");

        studenti.Add(new Student { Id = id, Nume = nume, Nota = nota });
        Console.WriteLine("Student adaugat");
    }

    // READ
    static void ShowAll()
    {
        foreach (var s in studenti)
            Console.WriteLine($"{s.Id} {s.Nume} {s.Nota}");
    }

    // UPDATE
    static void UpdateStudent()
    {
        Console.Write("Id student: ");
        int id = int.Parse(Console.ReadLine());

        var s = studenti.FirstOrDefault(x => x.Id == id)
            ?? throw new Exception("Student inexistent");

        Console.Write("Nota noua: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota < 1 || nota > 10)
            throw new Exception("Nota invalida");

        s.Nota = nota;
        Console.WriteLine("Nota actualizata");
    }

    // DELETE
    static void DeleteStudent()
    {
        Console.Write("Id student: ");
        int id = int.Parse(Console.ReadLine());

        var s = studenti.FirstOrDefault(x => x.Id == id)
            ?? throw new Exception("Student inexistent");

        studenti.Remove(s);
        Console.WriteLine("Student sters");
    }

    // LINQ – FILTRARE
    static void ShowPromovati()
    {
        var promovati = studenti.Where(s => s.Nota >= 5);
        foreach (var s in promovati)
            Console.WriteLine($"{s.Nume} - {s.Nota}");
    }
}
