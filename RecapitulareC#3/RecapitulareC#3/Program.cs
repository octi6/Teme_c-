namespace RecapitulareC_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ana",10);
            Student s2 = new Student("Matei", 8);

            s1.Nota = 10;

            s1.Afisare();
        }
    }
}
