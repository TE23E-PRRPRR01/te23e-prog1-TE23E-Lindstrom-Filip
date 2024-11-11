//Skapa lisat med slumpade tal 
//Validera användarens inmatning
Console.Clear();
Console.WriteLine("");

// Deklarera variabler
// Skapa en tom lista för att spara det slumpade talet

List<int> listaSlumptal = [];

// Variabler
int antal;
int maxvärde;
int minvärde;

// Fråga igen tills anändaren matar in giltigt svar
while (true)
{

    // Fråga användaren hur många slumptal som skall skapas
    Console.WriteLine("Ange antal slumptal");
    bool lyckadesantal = int.TryParse(Console.ReadLine(), out antal);
    Console.WriteLine("Ange högsta slumptal");
    bool lyckadesmaxvärde = int.TryParse(Console.ReadLine(), out maxvärde);
    Console.WriteLine("Ange lägsta slumptal");
    bool lyckadesminvärde = int.TryParse(Console.ReadLine(), out minvärde);

    if (!lyckadesantal || !lyckadesmaxvärde || !lyckadesminvärde)
    {
        Console.WriteLine("Du måste skriva ett heltal ");
    }
    else
    {
        break;
    }

}
Console.WriteLine($"Du vill ha {antal} slumptal");


// Slumpa fram ett antal tal
for (var i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(minvärde, maxvärde + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}

static int LäsInHelTal();
{
    int heltal =0;
    // Fråga igen tills anändaren matar in giltigt svar
    while (true)
    {

        // Fråga användaren hur många slumptal som skall skapas
        Console.WriteLine("Ange antal slumptal");
        bool lyckadesantal = int.TryParse(Console.ReadLine(), out antal);
        Console.WriteLine("Ange högsta slumptal");
        bool lyckadesmaxvärde = int.TryParse(Console.ReadLine(), out maxvärde);
        Console.WriteLine("Ange lägsta slumptal");
        bool lyckadesminvärde = int.TryParse(Console.ReadLine(), out minvärde);

        if (!lyckadesantal || !lyckadesmaxvärde || !lyckadesminvärde)
        {
            Console.WriteLine("Du måste skriva ett heltal ");
        }
        else
        {
            break;
        }

    }
    Console.WriteLine($"Du vill ha {antal} slumptal");

}