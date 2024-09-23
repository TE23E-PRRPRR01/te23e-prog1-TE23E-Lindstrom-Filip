// Litet program med meny
Console.Clear();
Console.WriteLine("Litet program med meny");
Console.OutputEncoding = System.Text.Encoding.Unicode;

// Variabel för valet
string val = "";

// Programloop som snurrar tills användaren säger avsluta
while (true)
{
    // Visar en meny ochläser in användarens val
    Console.WriteLine("""
    Välj ett av följande alternativ; 
    1, omvandla en text till versaler
    2, Omvandla en text till gemener
    3, Avsluta 
    välj ett av alternativen ovan 
    """);

    val = Console.ReadLine();

    // Hanter användarens val

    if (val == "1")
    {
      Console.Write("Skriv in en text: "); 
      string texten = Console.ReadLine().ToUpper();
      Console.WriteLine($"texten i verslar blir: (texten)");
       
    }
    else if (val == "2")
    {
      Console.Write("Skriv in en text: "); 
      string texten = Console.ReadLine().ToUpper();
      Console.WriteLine($"texten i verslar blir: (texten)");
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
