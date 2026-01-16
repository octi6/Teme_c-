// See https://aka.ms/new-console-template for more information

//===================Module 1: Introduction – .NET Fundamentals==========

/*
 CLR execută codul .NET și gestionează memoria, BCL oferă clasele de bază, iar .NET Runtime include CLR și bibliotecile necesare rulării aplicațiilor.

SDK-ul .NET este folosit pentru dezvoltarea aplicațiilor și conține compilatorul, CLI-ul dotnet, runtime-ul și șabloane de proiecte.

.NET Framework este pentru aplicații Windows vechi, .NET Core este cross-platform dar depășit, iar .NET 6+ este versiunea modernă recomandată pentru aplicații noi.

.NET suportă limbaje precum C#, VB.NET și F#.

NuGet este managerul de pachete .NET și este important pentru gestionarea și reutilizarea dependențelor.
 
 */


// ===================Sintaxă & Variabile=================

int numar;// declarare int
double numar2;// declarare double
string text;// declarare string

/*
 
 */

const double PI = 3.14;
const double TVA = 21;

Console.Write("Num1= ");
int num1 = Int32.Parse(Console.ReadLine());
Console.Write("Num2= ");
int num2 = Int32.Parse(Console.ReadLine());
Console.Write("Num3= ");
int num3 = Int32.Parse(Console.ReadLine());

double medie = (num1 + num2 + num3) / 3.0;
Console.WriteLine("Media este: "+ medie);

//====================Operatori & Expresii==================
Console.Write("Introdu varsta: "); 
var varsta = int.Parse(Console.ReadLine());
Console.Write("Introdu email: ");
var email = Console.ReadLine();

if(varsta < 18)
{
    Console.WriteLine("Varsta nu este valida");
}
else
{
    Console.WriteLine("Varsta este este valida");
}

if (!email.Contains("@") || email.Contains(".com") || email.Contains(".ro"))
{
    Console.WriteLine("Ëmailul este invalid");
}
else
{
    Console.WriteLine("Ëmailul este valid");
}

//====================Control Flow==================
Console.WriteLine("Numarul care o sa fie comparat");
int num = int.Parse(Console.ReadLine());

if(num < 0)
{
    Console.WriteLine("Numarul este mai mic ca zero");
}
else if(num > 0)
{
    Console.WriteLine("Numarul este mai mare ca zero");
}
else
{
    Console.WriteLine("Numarul este  zero ");
}


List<int> numerePare = new List<int>();
for (int i = 0; i < 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        numerePare.Add(i);
    }
}
int i2 = 0;
while (i2 < 100)
{
    Console.WriteLine(i2);
    i2 += 2;
}



foreach (int i3 in numerePare)
{
    Console.WriteLine(i3);
}


//==============Metode & Parametri==============

int calculeaza_factorial(int numar)
{
    if(numar < 0)
    {
        return 1;
    }
    if(num==1 || num == 0)
    {
        return 1;
    }
    return numar * calculeaza_factorial(numar-1);
}

Console.Write("Ïntroduceti factorialul:  ");
int factorial = Int32.Parse(Console.ReadLine());
Console.WriteLine(calculeaza_factorial(factorial));

//==============Scope & Modifiers=================

/*
public – membrul este accesibil de oriunde.
private – membrul este accesibil doar în interiorul clasei.
protected – membrul este accesibil în clasă și în clasele derivate.
internal – membrul este accesibil doar în același  proiect.
 
 */
//================Error Handling & Debugging=======

int deimpartit = 21;
int inpartitor = 0;

try
{
    int res = deimpartit / inpartitor;
    Console.WriteLine(res);

}
catch (Exception)
{

    throw new DivideByZeroException("Impartirea a esuat deoarece s-a incercat sa se imparta la 0");
}
finally
{
    Console.WriteLine("Operatia s-a terminat");
}

