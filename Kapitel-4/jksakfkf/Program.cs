
Console.Clear();
Console.WriteLine("Program för att skriva in i fil eller läsa från fil" );

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;


// Läs in text från filen
string val = "";


while (true)
{
    // Visar en meny ochläser in användarens val
    Console.WriteLine("""
    Välj ett av följande alternativ; 
    1, Skriv till fil
    2, Läs från fil
    3, Avsluta programmet 
    välj ett av alternativen ovan 
    """);

    val = Console.ReadLine();

    // Hanter användarens val

    if (val == "1")
    {
      Console.Write("Skriv in en text: "); 
      string text = Console.ReadLine();
      File.WriteAllText("filnamn.txt", text); 
    }
    else if (val == "2")
    {

      if (File.Exists("Filnamn.txt"))
      {
        string text = File.ReadAllText("filnamn.txt"); 
         Console.WriteLine(text);
      }
      else
      {
        Console.WriteLine("filen finns inte");
      }
    }
    else if (val == "3")
    {
      Console.WriteLine("Avslutar...");
      break;
    }
    else
    {
        Console.WriteLine("Felaktig inmatning försök igen!");
    }

}
