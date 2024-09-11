using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;

Console.Clear();
Console.WriteLine("Program för att få fram BMI");


Console.Write("Ange Vikt i kg ");

double vikt = double.Parse(Console.ReadLine());

Console.Write("ange längd i M");

double längd = double.Parse(Console.ReadLine());

double BMI = (vikt / (längd * längd));

Console.WriteLine(BMI);