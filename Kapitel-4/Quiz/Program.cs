// Quiz program 
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.Clear();



Console.WriteLine("Välkommen till Quizen!");

Console.WriteLine("I denna Quiz kommer du få 5 frågor om Arsenal");

Console.WriteLine("Lycka till!");

Console.Write("Vill du starta quizen! (J/N) ");
String svar = Console.ReadLine();

if (svar == "J")
{
    Console.WriteLine("vad Roligt, nu kör vi!");
}
else
{
    Console.WriteLine("Tråkmåns");
}


Console.WriteLine("""
Fråga 1: Hur Gammal Är Bukayo Saka? (A/B/C/D)
A: 22
B: 23
C: 24
D: 21
"""); 

Console.Write("Ange svar: ");

String Fråga1 = Console.ReadLine();

if (Fråga1 == "B")
{
    Console.WriteLine("Helt Rätt!");
}
else
{
    Console.WriteLine("Jävla TOTTENHAM fan");  
}



Console.WriteLine("""
Fråga 2: Hur många mål gjorde Bukayo Saka förra säsongen? (A/B/C/D)
A: 14
B: 15
C: 18
D: 21
""");

Console.Write("Ange svar: ");

String Fråga2 = Console.ReadLine();

if (Fråga2 == "B")
{
    Console.WriteLine("Helt Rätt!");
}
else
{
    Console.WriteLine("Jävla TOTTENHAM fan");  
}



Console.WriteLine("""
Fråga 3: Hur många mål gjorde Arsenal förra säsongen? (A/B/C/D)
A: 74
B: 81
C: 92
D: 88
""");

Console.Write("Ange svar: ");

String Fråga3 = Console.ReadLine();

if (Fråga3 == "D")
{
    Console.WriteLine("Helt Rätt!");
}
else
{
    Console.WriteLine("Jävla TOTTENHAM fan");  
}