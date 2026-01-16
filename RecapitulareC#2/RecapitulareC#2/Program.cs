using System.Text.RegularExpressions;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = numbers.Sum();

var studenti = new List<(string Nume, int Nota)>
{
    ("Ana", 8), ("Ion", 4), ("Maria", 9)
};

var promovati = studenti.Where(s => s.Nota >= 5);


Tuple<string,int> creaza_studenti(string nume, int nota)
{
    return new Tuple<string,int>(nume, nota);
}


string revers(string str)
{
    string rev_str = "";
    for (int i = str.Length; i > 0; i--)
    {
        rev_str += str[i];
    }
    return rev_str;
}


string email = Console.ReadLine();

bool valid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));

DateTime data1 = DateTime.Now;
DateTime data2 = new DateTime(2025,1,9);
TimeSpan dif = data1 - data2;
Console.WriteLine(dif);

var produse = new Dictionary<int, string>();
produse.Add(3, "Laptop");
produse.Add(4, "Telefon");
produse.Add(6, "Tableta");
produse.Add(9, "Cablu USB");

Console.WriteLine("Filtrare (>5):");
foreach (var n in numbers.Where(n => n > 5))
    Console.WriteLine(n);

Console.WriteLine("Sortare:");
foreach (var n in numbers.OrderBy(n => n))
    Console.WriteLine(n);

Console.WriteLine($"Count: {numbers.Count()}");
Console.WriteLine($"Sum: {numbers.Sum()}");
Console.WriteLine($"Average: {numbers.Average()}");
