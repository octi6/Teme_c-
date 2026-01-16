using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RecapitulareC_3
{
    internal class Student
    {
        private int nota;

        public string nume { get; set; }

        public int Nota
        {
            get;
            set
            {
                if (value >= 1 && value <= 10)
                    nota = value;
            }
        }

        public void Afisare()
        {
            Console.WriteLine($"{nume} - Nota: {nota}");
        }

        public Student() { }
        public Student(string nume, int nota)
        {
            this.nume = nume;
            this.nota = nota;
        }
    }
}
