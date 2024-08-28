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
Console.WriteLine($"hej! {förnamn} {efternamn}");

// är det filip som loggar in?
if (förnamn == "filip")
{
    Console.WriteLine("vad trevligt att du är tillbaka");
    
}


if (efternamn == "lindström")
{
    Console.WriteLine("vackert efternamn!");
}