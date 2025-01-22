/* *************************
*********M A I N ***********
***************************/

VisaPresentation();

while (true)
{
    VisaMeny();
    String val = Console.ReadLine();

    if (val == "1")
    {
        SparaMedelande();
    }
    else if (val == "2")
    {
        LäsaMeddelande();
    }
    else if (val == "3")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {

    }

}


/* *************************
*********M A I N ***********
***************************/
static void VisaPresentation()
{
    Console.Clear();
    Console.WriteLine("""
    * Program för att spara meddelande på disken *
    """);
}

static void VisaMeny()
{
    Console.WriteLine("Visa meny");

    Console.WriteLine("""
    1.Spara meddelande
    2.läsa meddelande
    3.avsluta programmet
    """);
}

static void SparaMedelande()
{
    
    Console.Write("Ange ett meddelande:   ");
    string meddelande = Console.ReadLine();
    File.WriteAllText("meddelande.txt", meddelande);
    Console.WriteLine("ditt meddelande har sparats!");
}

static void LäsaMeddelande(string filen)
{
    string meddelande = File.ReadAllText (filen);
    Console.WriteLine("Ditt senaste ");
    Console.WriteLine("____________________");
    Console.WriteLine(meddelande);
    Console.WriteLine("_______________");
}