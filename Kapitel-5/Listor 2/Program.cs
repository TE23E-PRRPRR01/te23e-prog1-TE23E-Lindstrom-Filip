Console.Clear();
Console.WriteLine("Allt om listor");


//Skapa en tom lista
List<string> listanamn = [];

//Infoga i listan
listanamn.Add("Tyr");
listanamn.Add("hej");
Console.WriteLine(listanamn.Count);

//skriv ut listan (går inte)
Console.WriteLine(listanamn);

//skriv ut lista med loop
foreach (var namn in listanamn)
{
    Console.WriteLine($"- {namn}");
}

//Skriv ut första elementet i listan (index = 0)
Console.WriteLine($"första elementet: {listanamn[0]}");

//Skriv ut två namn ur listan 
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"- {listanamn[i]}");
}

//skriv ut alla namn i listan med for-loop
for (int i = 0; i < listanamn.Count; i++)
{
    Console.WriteLine($"{i}: {listanamn[i]}");
}


