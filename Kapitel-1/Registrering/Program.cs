// Program för att registrera förnamn och efternamn
using System.ComponentModel;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding =System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn");
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);
Console.WriteLine(%"hej! {förnamn} {efternamn}");